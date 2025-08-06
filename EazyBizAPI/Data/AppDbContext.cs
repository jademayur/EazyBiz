using EazyBizAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace EazyBizAPI.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
       
        public DbSet<User> Users { get; set; }
    }
}
