using Microsoft.EntityFrameworkCore;
using RetailResaleApi.Data.Entities;

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

        public DbSet<RetailResaleApi.Data.Entities.Condition>? Condition { get; set; }

        public DbSet<RetailResaleApi.Data.Entities.Category>? Category { get; set; }

        public DbSet<RetailResaleApi.Data.Entities.SubCategory>? SubCategory { get; set; }
    }
}
