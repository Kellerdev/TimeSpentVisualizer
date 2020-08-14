using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TimeSpentVisualizer.Data
{
    public class Timeline
    {
        public List<HourUnit[]> HourUnits { get; }
        public int EdgeLength { get; set; }

        public Timeline(List<HourUnit[]> hourUnits, int edgeLength)
        {
            HourUnits = hourUnits;
            EdgeLength = edgeLength;
        }
    }
}
