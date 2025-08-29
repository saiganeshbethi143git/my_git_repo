using Microsoft.EntityFrameworkCore;
using EmployeeAPI_WebApp.Models;

namespace EmployeeAPI_WebApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Employee> Employees { get; set; } = null!;
    }
}
