using Microsoft.EntityFrameworkCore;
using Task1.Models;
using Task1.Service.IService;

namespace Task1.Service.IServicImpl
{
    public class ProductService : IProductService
    {

        private readonly Task1DbContext _context;

        public ProductService(Task1DbContext context)
        {
            _context = context;
        }

        public async Task<Product> GetProductByIdAsync(int productId) =>
            await _context.Products.FirstOrDefaultAsync(p => p.ProductId == productId);

        public async Task<Product> CreateProductAsync(Product product)
        {
            _context.Products.Add(product);
            await _context.SaveChangesAsync();
            return product;
        }

        public async Task<IEnumerable<Product>> GetProductsAsync(int pageNumber, int pageSize)
        {
            return await _context.Products
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();
        }

        public async Task<bool> UpdateProductAsync(int id, Product product)
        {
            var existingProduct = await _context.Products.FindAsync(id);
            if (existingProduct == null) return false;

            existingProduct.ProductName = product.ProductName;
            existingProduct.CategoryId = product.CategoryId;
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteProductAsync(int id)
        {
            var existingProduct = await _context.Products.FindAsync(id);
            if (existingProduct == null) return false;

            _context.Products.Remove(existingProduct);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
