using _3thPartySoftware.DAL.SQL;
using _3thPartySoftware.Entities;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.IO;

namespace _3thPartySoftware
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbContext = new ExternalSoftware();

            DataSeeder.SeedAsientos(dbContext);

            GenerateAsiento.Generate();

            Console.WriteLine("Data Generated");

            Console.ReadKey();
        }
    }
}
