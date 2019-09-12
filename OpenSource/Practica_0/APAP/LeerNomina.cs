using APAP.DAL.SQL;
using APAP.Domain;
using APAP.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using TinyCsvParser;

namespace APAP
{
    public class LeerNomina
    {
        public static string FileName = @"C:\temp\NominaApec.txt";

        public async static void ReadNomina()
        {

            CsvParserOptions _options = new CsvParserOptions(false, '|');
            CsvParserNomina _mapper = new CsvParserNomina();
            CsvParser<Nomina> parser = new CsvParser<Nomina>(_options, _mapper);
            try
            {
                var result = parser.ReadFromFile(FileName, Encoding.UTF8);
                using (var apapDbContext = new ApapDbContext())
                {
                    foreach (var item in result)
                    {
                        var nomina = new Nomina
                        {
                            TipoRegistro = item.Result.TipoRegistro,
                            ClaveNomina = item.Result.ClaveNomina,
                            TipoDocumento = item.Result.TipoDocumento,
                            NoDocumento = item.Result.NoDocumento,
                            MontoPagar = item.Result.MontoPagar,
                            Cuenta = item.Result.Cuenta
                        };
                        await apapDbContext.Nominas.AddAsync(nomina);
                    }

                    await apapDbContext.SaveChangesAsync();
                    apapDbContext.Dispose();
                    Console.WriteLine("Data Loaded");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
