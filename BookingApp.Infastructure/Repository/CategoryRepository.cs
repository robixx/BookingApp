using BookingApp.Domain.Interface;
using BookingApp.Domain.Models;
using BookingApp.Infastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace BookingApp.Infastructure.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly DataBaseConnection _connection;

        public CategoryRepository(DataBaseConnection connection)
        {
            _connection = connection;
        }

        public async Task<Category> CreateAsync(Category category)
        {
            await _connection.Category.AddAsync(category);
            await _connection.SaveChangesAsync();
            return category;
        }

        public Task<int> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Category>> GetAllAsync()
        {
            var list = await _connection.Category.ToListAsync();
            return list;
        }

        public Task<Category> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpDateAsync(int id, Category category)
        {
            throw new NotImplementedException();
        }
    }
}
