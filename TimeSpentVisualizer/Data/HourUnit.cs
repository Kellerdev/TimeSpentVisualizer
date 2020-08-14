using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TimeSpentVisualizer.Data
{
    public class HourUnit
    {
        public int Hour { get; }
        public List<TimeUnit[]> TimeUnits { get; }

        public HourUnit(int hour, List<TimeUnit[]> timeUnits)
        {
            Hour = hour;
            TimeUnits = timeUnits;
        }
    }
}
