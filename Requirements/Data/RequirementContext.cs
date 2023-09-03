using Microsoft.EntityFrameworkCore;
using Requirements.Models;

namespace Requirements.Data
{
    public class RequirementContext : DbContext
    {
        public RequirementContext(DbContextOptions<RequirementContext> options)
            : base(options)
        { 
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Address> Address { get; set; }
    }
}
