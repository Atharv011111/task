using Task1.Models;

namespace Task1.Service.IService
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> GetCategoryAsync();
        Task<Category> GetCategoryByIdAsync(int id);
        Task<Category> CreateCategoryAsync(Category category);
        Task<bool> UpdateCategoryAsync(int id, Category category);
        Task<bool> DeleteCategoryAsync(int id);
    }
}
