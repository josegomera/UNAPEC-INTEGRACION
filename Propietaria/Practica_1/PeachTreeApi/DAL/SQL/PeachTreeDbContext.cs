using _3thPartySoftware.Entities;
using Microsoft.EntityFrameworkCore;

namespace _3thPartySoftware.DAL.SQL
{
    public class PeachTreeDbContext : DbContext
    {
        public DbSet<AsientoExterno> AsientosExternos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=PeachTreeDB; Integrated Security=True;");
        }
    }
}
