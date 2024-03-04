using Microsoft.EntityFrameworkCore;
using ProjetoJWT.WebAPI.Domain.Entities;

namespace ProjetoJWT.WebAPI.Data.db
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> op) : base(op)
        {
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
