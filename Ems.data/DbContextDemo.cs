using Ems.Models;
using Microsoft.EntityFrameworkCore;
using Models;

namespace Ems.data
{
    public class DbContextDemo:DbContext
    {
        public DbContextDemo(DbContextOptions<DbContextDemo> options):base(options) { }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<LoginDetails> LoginDetails { get; set; }

    }
}
