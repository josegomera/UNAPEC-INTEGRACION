using APEC.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace APEC.DAL.SQL
{
    public class ApecDbContext : DbContext
    {
        public DbSet<Nomina> Nominas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = NominaApec; Integrated Security = True;");
        }
    }
}
