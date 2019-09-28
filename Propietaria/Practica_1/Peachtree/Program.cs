using Newtonsoft.Json;
using System;
using System.IO;

namespace Peachtree
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader r = new StreamReader(@"C:\temp\Asientos.json"))
            {
                var JsonData = r.ReadToEnd();
                
                var data = JsonConvert.DeserializeObject(JsonData);
                
                File.WriteAllText(@"C:\temp\AsientosPeachTree.json", data.ToString());
            }

            Console.WriteLine("Data Inserted");

            Console.ReadKey();
        }
    }
}
