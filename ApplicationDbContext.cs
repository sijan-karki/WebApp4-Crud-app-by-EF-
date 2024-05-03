using Microsoft.EntityFrameworkCore;
using WebApp4BySijan.Models;

namespace WebApp4BySijan
{
    public class ApplicationDbcontext : DbContext
    {
        public ApplicationDbcontext(DbContextOptions<ApplicationDbcontext> options) : base(options) { }

        public DbSet<Student> Students { get; set; }
    }
}
