using BookingApp.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace BookingApp.Infastructure.Data
{
    public class DataBaseConnection : DbContext
    {
        public DataBaseConnection(DbContextOptions<DataBaseConnection> options) : base(options)
        {
        }

        public DbSet<Category> Category { get; set; }
    }
}
