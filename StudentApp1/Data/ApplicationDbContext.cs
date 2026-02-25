using Microsoft.EntityFrameworkCore;
using StudentApp1.Models.Entities;

namespace StudentApp1.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {    
        }
        public DbSet<Student> Students { get; set; }
    }
}
