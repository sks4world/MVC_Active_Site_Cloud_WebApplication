using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Active_Site_Cloud_WebApplication.Models
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<country> countries { get; set; }

        public DbSet<city> cities { get; set; }

        public DbSet<yearClass> yearClasses { get; set; }

        public DbSet<food_recall> food_recalls { get; set; }

        public DbSet<drug_recall> drug_recalls
        { get; set; }
    }
}
