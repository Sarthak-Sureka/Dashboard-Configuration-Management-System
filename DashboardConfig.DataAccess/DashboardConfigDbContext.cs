using DashboardConfig.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashboardConfig.DataAccess
{
    public class DashboardConfigDbContext : DbContext
    {
        public DbSet<Dashboard> Dashboard { get; set; }
    }
}
