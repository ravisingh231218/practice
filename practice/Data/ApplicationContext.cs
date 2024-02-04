using Microsoft.EntityFrameworkCore;
using practice.Models;

namespace practice.Data
{
    public class ApplicationContext:DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) 
        { 
        }
        public DbSet<User> users { get; set; }
    }
}
