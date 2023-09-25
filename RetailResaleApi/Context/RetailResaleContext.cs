using Microsoft.EntityFrameworkCore;

namespace RetailResaleApi.Context
{
    public class RetailResaleContext : DbContext
    {
        public RetailResaleContext(DbContextOptions<RetailResaleContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<RetailResaleApi.Data.Entities.Product>? Product { get; set; }
    }
}
