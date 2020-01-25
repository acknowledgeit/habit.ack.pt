using System;

namespace Habitus.Server.Models
{
    public class Habit
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public Cycle Cycle { get; set; }
    }
}
