using Microsoft.EntityFrameworkCore;

namespace WepAPICore.Model
{
    public class UserDbContext : DbContext
    {
        public UserDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }    
    }
}
