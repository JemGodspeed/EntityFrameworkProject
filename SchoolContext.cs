using System.Data.Entity;
using EntityFramework;

namespace CodeFirstDemo
{
    public class SchoolContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
    }
}
