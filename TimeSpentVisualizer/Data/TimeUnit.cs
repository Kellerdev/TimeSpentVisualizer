using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace TimeSpentVisualizer.Data
{
    public class TimeUnit
    {
        #region properties
        public DateTime From { get; }
        public DateTime To { get; }
        public DateTime Date { get; }
        public Color Color { get; }
        public int RowNumber { get; }

        public TimeUnit(DateTime from, DateTime to, DateTime date, Color color, int rowNumber)
        {
            From = from;
            To = to;
            Date = date;
            Color = color;
            RowNumber = rowNumber;
        }

        #endregion properties

        #region Ctor

        #endregion Ctor
    }
}
