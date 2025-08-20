using Microsoft.AspNetCore.Mvc;
using API.Data;
using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly AppDbContext _context;
        public EmployeeController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var employees = await _context.Employees.ToListAsync();
            return Ok(employees);
        }

        [HttpPost("seed")]
        public async Task<IActionResult> Seed()
        {
            if (await _context.Employees.AnyAsync())
                return BadRequest("Already seeded");

            var data = new List<Employee>
            {
                new Employee { Name = "John Doe", Email = "john@example.com", Designation = "Manager", Department = "Sales", JoiningDate = DateTime.Parse("2022-01-10"), Salary = 75000 },
                new Employee { Name = "Jane Smith", Email = "jane@example.com", Designation = "Developer", Department = "IT", JoiningDate = DateTime.Parse("2021-03-15"), Salary = 65000 },
                new Employee { Name = "Alice Johnson", Email = "alice@example.com", Designation = "Designer", Department = "Marketing", JoiningDate = DateTime.Parse("2020-07-22"), Salary = 60000 },
                new Employee { Name = "Bob Brown", Email = "bob@example.com", Designation = "Support", Department = "Customer Service", JoiningDate = DateTime.Parse("2019-11-05"), Salary = 50000 },
                new Employee { Name = "Charlie Lee", Email = "charlie@example.com", Designation = "HR", Department = "Human Resources", JoiningDate = DateTime.Parse("2023-02-01"), Salary = 70000 },
                new Employee { Name = "Eva Green", Email = "eva@example.com", Designation = "Accountant", Department = "Finance", JoiningDate = DateTime.Parse("2022-09-18"), Salary = 68000 },
                new Employee { Name = "Frank White", Email = "frank@example.com", Designation = "Analyst", Department = "Business", JoiningDate = DateTime.Parse("2021-12-12"), Salary = 72000 },
                new Employee { Name = "Grace Black", Email = "grace@example.com", Designation = "Consultant", Department = "Consulting", JoiningDate = DateTime.Parse("2020-05-30"), Salary = 80000 },
                new Employee { Name = "Henry King", Email = "henry@example.com", Designation = "Intern", Department = "IT", JoiningDate = DateTime.Parse("2023-06-10"), Salary = 35000 },
                new Employee { Name = "Ivy Queen", Email = "ivy@example.com", Designation = "Lead", Department = "Operations", JoiningDate = DateTime.Parse("2018-08-25"), Salary = 90000 }
            };
            _context.Employees.AddRange(data);
            await _context.SaveChangesAsync();
            return Ok();
        }
    }
}
