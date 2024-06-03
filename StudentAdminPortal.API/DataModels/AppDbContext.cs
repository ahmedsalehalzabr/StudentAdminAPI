using Microsoft.EntityFrameworkCore;

namespace StudentAdminPortal.API.DataModels
{
    public class AppDbContext : DbContext 
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {
            
        }

        public DbSet<Student> Student { get; set; }
        public DbSet<Gender> Gender { get; set; }

        public DbSet<Address> Address { get; set; }
    }
}
