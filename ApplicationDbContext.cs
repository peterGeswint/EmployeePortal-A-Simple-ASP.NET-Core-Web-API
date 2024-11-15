using EmployeePortal.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeePortal
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {

        }
        public DbSet<Employee> Employees { get; set; }
    }
}
