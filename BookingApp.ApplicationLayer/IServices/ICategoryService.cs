using BookingApp.Domain.Models;

namespace BookingApp.ApplicationLayer.IServices
{
    public interface ICategoryService
    {
        Task<List<Category>> GetAllAsync();
        Task<Category> GetByIdAsync(int id);
        Task<Category> CreateAsync(Category category);
        Task<int> UpDateAsync(int id, Category category);
        Task<int> DeleteAsync(int id);
    }
}
