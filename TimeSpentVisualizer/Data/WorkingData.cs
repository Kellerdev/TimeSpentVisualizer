using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TimeSpentVisualizer
{
    public class WorkingData
    {
            public Guid DataSetId { get; set; }
            public DateTime FromOrg { get; set; }
            public DateTime ToOrg { get; set; }
            public DateTime Date { get; set; }
            public DateTime FromRounded { get; set; }
            public DateTime ToRounded { get; set; }
    }
}
