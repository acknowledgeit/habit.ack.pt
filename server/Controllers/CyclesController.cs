using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Habitus.Server.Models;

namespace Habitus.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CyclesController : ControllerBase {
        private readonly ILogger<CyclesController> _logger;

        public CyclesController(ILogger<CyclesController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Cycle> Get()
        {
            var sunday = DateTime.Today.AddDays(-(int)DateTime.Today.DayOfWeek);

            return new List<Cycle> {
                new Cycle
                {
                    Start = sunday,
                    End = sunday.AddDays(15)
                }
            };
        }
    }
}
