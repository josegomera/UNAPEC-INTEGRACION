using _3thPartySoftware.DAL.SQL;
using System;
using System.Collections.Generic;
using System.Linq;

namespace _3thPartySoftware.Entities
{
    public class DataSeeder
    {
        public async static void SeedAsientos(ExternalSoftware dbContext)
        {
            if (!dbContext.Asientos.Any())
            {
                var asientos = new List<Asiento>
                {
                    new Asiento { NoAsiento = "2566", Description = "Pago de Energia Electrica", Fecha = DateTime.UtcNow.AddMinutes(-240),
                        TipoMovimiento = TipoMovimiento.DB, Cuenta = "2563874", MontoMovimiento = 45751},
                    new Asiento { NoAsiento = "5698", Description = "Pago de Alquiler (Ubicacio Sabana Larga)", Fecha = DateTime.UtcNow.AddMinutes(-240),
                        TipoMovimiento = TipoMovimiento.DB, Cuenta = "2563874", MontoMovimiento = 65000},
                    new Asiento { NoAsiento = "4878", Description = "Pago Nomina", Fecha = DateTime.UtcNow.AddMinutes(-240),
                        TipoMovimiento = TipoMovimiento.DB, Cuenta = "2563874", MontoMovimiento = 350956},

                    new Asiento { NoAsiento = "9636", Description = "Cuentas Por Cobrar", Fecha = DateTime.UtcNow.AddMinutes(-240),
                        TipoMovimiento = TipoMovimiento.CR, Cuenta = "2563874", MontoMovimiento = 550632},
                    new Asiento { NoAsiento = "9156", Description = "Ventas 40 Unidades de Madera 25x25", Fecha = DateTime.UtcNow.AddMinutes(-240),
                        TipoMovimiento = TipoMovimiento.CR, Cuenta = "2563874", MontoMovimiento = 150236},
                    new Asiento { NoAsiento = "6325", Description = "Horarios Profesionales", Fecha = DateTime.UtcNow.AddMinutes(-240),
                        TipoMovimiento = TipoMovimiento.CR, Cuenta = "2563874", MontoMovimiento = 652659}
                };

                await dbContext.AddRangeAsync(asientos);
                await dbContext.SaveChangesAsync();
                await dbContext.DisposeAsync();
                    
            }
        }
    }
}