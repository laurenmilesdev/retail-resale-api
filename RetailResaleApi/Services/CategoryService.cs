using Microsoft.EntityFrameworkCore;
using RetailResaleApi.Context;
using RetailResaleApi.Data.Entities;
using RetailResaleApi.Interfaces;

namespace RetailResaleApi.Services
{
    public class CategoryService : BaseService, ICategoryService
    {
        public CategoryService(RetailResaleContext dbContext) : base(dbContext) { }

        public async Task<Category?> GetCategoryById(int id)
        {
            var category = await DbContext.Set<Category>()
                .Include(ctx => ctx.SubCategories)
                .FirstOrDefaultAsync(ctx => ctx.Id == id);

            return category;
        }

        public async Task<IEnumerable<Category>> GetCategories()
        {
            var categories = await DbContext.Set<Category>()
                .Include(ctx => ctx.SubCategories)
                .ToListAsync();

            return categories;
        }
    }
}
