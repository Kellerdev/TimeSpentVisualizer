using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TimeSpentVisualizer.Data
{
    public class VisualizationContext: DbContext
    {
        public DbSet<WorkingData> DataSets { get; set; }
    }   
}
