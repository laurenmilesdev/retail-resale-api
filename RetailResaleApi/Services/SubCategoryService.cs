using Microsoft.EntityFrameworkCore;
using RetailResaleApi.Context;
using RetailResaleApi.Data.Entities;
using RetailResaleApi.Interfaces;

namespace RetailResaleApi.Services
{
    public class SubCategoryService : BaseService, ISubCategoryService
    {
        public SubCategoryService(RetailResaleContext dbContext) : base(dbContext) { }

        public async Task<SubCategory?> GetSubCategoryById(int id)
        {
            var subCategory = await DbContext.Set<SubCategory>()
                .Include(ctx => ctx.Category)
                .FirstOrDefaultAsync(ctx => ctx.Id == id);

            return subCategory;
        }

        public async Task<IEnumerable<SubCategory>> GetSubCategoriesByCategoryId(int categoryId)
        {
            var subCategories = await DbContext.Set<SubCategory>()
                .Where(ctx => ctx.CategoryId == categoryId)
                .Include(ctx => ctx.Category)
                .ToListAsync();

            return subCategories;
        }

        public async Task<IEnumerable<SubCategory>> GetSubCategories()
        {
            var subCategories = await DbContext.Set<SubCategory>()
                .Include(ctx => ctx.Category)
                .ToListAsync();

            return subCategories;
        }
    }
}
