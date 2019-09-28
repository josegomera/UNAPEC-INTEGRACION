using _3thPartySoftware.DAL.SQL;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace _3thPartySoftware
{
    public class GenerateAsiento
    {
        public async static void Generate()
        {

            try
            {
                if (!Directory.Exists(@"C:\temp"))
                {
                    Directory.CreateDirectory(@"C:\temp");
                }

                var query = "SELECT * FROM Asientos ";
                using (var _dbContext = new ExternalSoftware())
                {
                    var asientos = await _dbContext.Asientos.FromSqlRaw(query).ToListAsync();

                    var JsonData = JsonConvert.SerializeObject(asientos, new StringEnumConverter());

                    File.WriteAllText(@"C:\temp\Asientos.json", JsonData);

                    await _dbContext.DisposeAsync();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
