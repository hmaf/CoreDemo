using Microsoft.EntityFrameworkCore;

namespace CoreDemo_Api.DataAccessLayer
{
    public class Context:DbContext
    {
        public Context(DbContextOptions<Context> options):base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }
    }
}
