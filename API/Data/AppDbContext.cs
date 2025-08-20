using Microsoft.EntityFrameworkCore;
using API.Models;

namespace API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<User> Users { get; set; }
        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            var employees = new List<Employee>();
            var designations = new[] { "Manager", "Developer", "Designer", "Support", "HR", "Accountant", "Analyst", "Consultant", "Intern", "Lead" };
            var departments = new[] { "Sales", "IT", "Marketing", "Customer Service", "Human Resources", "Finance", "Business", "Consulting", "Operations" };
            for (int i = 1; i <= 100; i++)
            {
                employees.Add(new Employee
                {
                    Id = i,
                    Name = $"Employee {i}",
                    Email = $"employee{i}@example.com",
                    Designation = designations[i % designations.Length],
                    Department = departments[i % departments.Length],
                    JoiningDate = new DateTime(2020, 1, 1).AddDays(i * 10),
                    Salary = 40000 + (i * 500)
                });
            }
            modelBuilder.Entity<Employee>().HasData(employees);
        }
    }
}
