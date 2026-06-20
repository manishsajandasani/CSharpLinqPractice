using CSharpLinqPractice.Models;
using Microsoft.EntityFrameworkCore;

namespace CSharpLinqPractice.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    }
}
