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
    public class HabitsController : ControllerBase {
        private readonly string[] _habits = new string[] {
            "Read: 20 mins/day or finish chapter",
            "Music: 15 mins fingerpicking",
            "Music: 15 mins scale and chords",
            "Exercise: Climb, lift or 15 mins cardio",
            "Sleep: Be in bed by 22:30",
        };

        private readonly ILogger<HabitsController> _logger;

        public HabitsController(ILogger<HabitsController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Habit> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 10).Select(_ => new Habit
            {
                Name = _habits[rng.Next(_habits.Length)],
                Description = _habits[rng.Next(_habits.Length)],
                Cycle = null
            });
        }
    }
}
