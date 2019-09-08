using APEC.DAL.SQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace APEC.Entity
{
    public class DataSeeder
    {
        public async static void SeedNomina(ApecDbContext dbContext)
        {
            if (!dbContext.Nominas.Any())
            {
                var nominas = new List<Nomina>
                {
                    new Nomina { TipoRegistro = "D", ClaveNomina = "N01", TipoDocumento = "C", NoDocumento = "40223157997",
                        MontoPagar = 25000,
                        Cuenta = "2547896321"
                    },
                    new Nomina { TipoRegistro = "D", ClaveNomina = "N01", TipoDocumento = "C", NoDocumento = "22315239797",
                        MontoPagar = 30000,
                        Cuenta = "4047895326"
                    },
                    new Nomina { TipoRegistro = "D", ClaveNomina = "N01", TipoDocumento = "C", NoDocumento = "22314057998",
                        MontoPagar = 33000,
                        Cuenta = "9949906830"
                    },
                    new Nomina { TipoRegistro = "D", ClaveNomina = "N01", TipoDocumento = "C", NoDocumento = "40225208890",
                        MontoPagar = 45000,
                        Cuenta = "6557796531"
                    }
                };

                await dbContext.AddRangeAsync(nominas);
                await dbContext.SaveChangesAsync();
            }
        }
    }
}
