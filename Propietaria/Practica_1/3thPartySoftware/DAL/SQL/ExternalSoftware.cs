using _3thPartySoftware.Entities;
using Microsoft.EntityFrameworkCore;

namespace _3thPartySoftware.DAL.SQL
{
    public class ExternalSoftware : DbContext
    {
        public DbSet<Asiento> Asientos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ExternalDB; Integrated Security=True;");
        }
    }
}
