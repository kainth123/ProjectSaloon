using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjectSaloon.Models;

namespace ProjectSaloon.Data
{
    public class ProjectSaloonContext : DbContext
    {
        public ProjectSaloonContext (DbContextOptions<ProjectSaloonContext> options)
            : base(options)
        {
        }

        public DbSet<ProjectSaloon.Models.Saloon> Saloon { get; set; }

        public DbSet<ProjectSaloon.Models.Beautician> Beautician { get; set; }

        public DbSet<ProjectSaloon.Models.Customer> Customer { get; set; }

        public DbSet<ProjectSaloon.Models.Product> Product { get; set; }
    }
}
