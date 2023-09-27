using RetailResaleApi.Data.Entities;

namespace RetailResaleApi.Interfaces
{
    public interface ICategoryService
    {
        Task<Category?> GetCategoryById(int id);
        Task<IEnumerable<Category>> GetCategories();
    }
}
