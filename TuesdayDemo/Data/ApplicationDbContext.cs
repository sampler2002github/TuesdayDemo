using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Metrics;
using TuesdayDemo.Data.Models;

namespace TuesdayDemo.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
        public DbSet<Country> Countries { get; set; }
        public DbSet<State> Statetbl { get; set; }
        public DbSet<City> Citytbl{ get; set; }
        public DbSet<User> Users { get; set; }
        
    }
}
 