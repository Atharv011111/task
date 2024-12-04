using Task1.Models;

namespace Task1.Service.IService
{
    public interface IProductService
    {

        Task<IEnumerable<Product>> GetProductsAsync(int pageNumber, int pageSize);
        Task<Product> GetProductByIdAsync(int productId);
        Task<Product> CreateProductAsync(Product product);
        Task<bool> UpdateProductAsync(int id, Product product);
        Task<bool> DeleteProductAsync(int id);
    }
}
