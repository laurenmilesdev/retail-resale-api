using RetailResaleApi.Data.Entities;

namespace RetailResaleApi.Interfaces
{
    public interface ISubCategoryService
    {
        Task<SubCategory?> GetSubCategoryById(int id);
        Task<IEnumerable<SubCategory>> GetSubCategoriesByCategoryId(int categoryId);
        Task<IEnumerable<SubCategory>> GetSubCategories();
    }
}
