using APAP.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace APAP.DAL.SQL
{
    public class ApapDbContext : DbContext
    {
        public DbSet<Nomina> Nominas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = APAPDB; Integrated Security = True;");
        }
    }
}
