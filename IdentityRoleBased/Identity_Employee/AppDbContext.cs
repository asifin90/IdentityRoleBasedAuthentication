using Microsoft.EntityFrameworkCore;
using Identity_Employee.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Identity_Employee
{
    public class AppDbContext : IdentityDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> option) : base(option)
        {

        }
        public DbSet<Models.Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Seed();
        }
    }
}
