using Microsoft.EntityFrameworkCore;
using DATINGAPP.API.Models;
namespace DATINGAPP.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){}
        public DbSet<Value> Values { get; set; }
        public DbSet<User> Users { get; set; }
        
        
    }
}