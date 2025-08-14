using Microsoft.EntityFrameworkCore;
using Learning.Models;

using Microsoft.EntityFrameworkCore;

namespace Learning.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Employee> Employees { get; set; } = default!;
    }
}