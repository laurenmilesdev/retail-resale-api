using RetailResaleApi.Data.Entities;

namespace RetailResaleApi.Interfaces
{
    public interface IProductService
    {
        Task<Product?> GetProductById(int id);
        Task<IEnumerable<Product>> GetProducts();

        Task<int> CreateProduct(Product product);
        Task<int?> UpdateProduct(int id, Product product);
        Task<bool> DeleteProduct(int id);
    }
}
