using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace  Lab1_13680.Models
{
    public class StudentDbContext : IdentityDbContext<UserEntity, UserRole, int>
    {

        public StudentDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Student> Student { get; set; } = null!;
    }

}
