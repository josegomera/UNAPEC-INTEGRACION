using APEC.DAL.SQL;
using APEC.Entity;
using System;

namespace APEC
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var dbContext = new ApecDbContext())
            {
                DataSeeder.SeedNomina(dbContext);
                dbContext.Dispose();
            };
            GenerarNomina.Generate();
            Console.ReadLine();
        }

        
    }
}