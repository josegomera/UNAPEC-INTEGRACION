using Cuentas_x_Cobrar_Carol.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cuentas_x_Cobrar_Carol.DAL
{
    public class FacturaDBContext : DbContext
    {
        public DbSet<Factura> Facturas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=FaturaDB; Integrated Security=True;");
        }
    }
}
