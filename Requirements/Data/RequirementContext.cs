using Microsoft.EntityFrameworkCore;

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

        public DbSet<AddressInDatabase> Address { get; set; }
    }
}
