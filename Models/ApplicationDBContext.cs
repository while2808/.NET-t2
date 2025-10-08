using Microsoft.EntityFrameworkCore;

namespace Mark_10_MVC.Models
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) :base(options)
        {
            
        }
        public DbSet<Student> Students { get; set; }
    }
}
