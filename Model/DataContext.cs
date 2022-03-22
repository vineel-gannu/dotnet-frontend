using Microsoft.EntityFrameworkCore;

namespace FirstAPI.Model
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Student> Students { get; set; }
    }
}
