using HDD.Entities;
using Microsoft.EntityFrameworkCore;

namespace HDD.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options) { }

        public DbSet<User> User { get; set; }
        public DbSet<Role> Role { get; set; }

    }
}