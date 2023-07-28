using Microsoft.EntityFrameworkCore;
using RetailResaleApi.Context;
using RetailResaleApi.Data.Entities;
using RetailResaleApi.Interfaces;

namespace RetailResaleApi.Services
{
    public class ProductService : BaseService, IProductService
    {
        public ProductService(RetailResaleContext dbContext) : base(dbContext) { }

        public async Task<Product?> GetProductById(int id)
        {
            var product = await DbContext.Set<Product>()
                .Include(ctx => ctx.SubCategory)
                .ThenInclude(ctx => ctx.Category)
                .FirstOrDefaultAsync(ctx => ctx.Id == id);

            return product;
        }

        public async Task<IEnumerable<Product>> GetProducts()
        {
            var products = await DbContext.Set<Product>()
               .Include(p => p.SubCategory)
               .ThenInclude(p => p.Category)
               .ToListAsync();

            return products;
        }

        public async Task<int> CreateProduct(Product product)
        {
            var result = await DbContext.Set<Product>().AddAsync(product);

            await DbContext.SaveChangesAsync();

            return result.Entity.Id;
        }

        public async Task<int?> UpdateProduct(int id, Product product)
        {
            DbContext.Entry(product).State = EntityState.Modified;

            try
            {
                await DbContext.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductExists(id)) return null;
                else throw;
            }

            return id;
        }

        public async Task<bool> DeleteProduct(int id)
        {
            var product = await DbContext.Set<Product>().FindAsync(id);

            if (product != null) DbContext.Set<Product>().Remove(product);

            return await DbContext.SaveChangesAsync() > 0;
        }

        private bool ProductExists(int id)
        {
            return (DbContext.Product?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
