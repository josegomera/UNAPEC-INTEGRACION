using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.IO;

namespace APEC
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader r = new StreamReader(@"C:\temp\file.json"))
            {
                string json = r.ReadToEnd();
                var items = JsonConvert.DeserializeObject(json);
                
                System.IO.File.WriteAllText(@"C:\temp\APECMoney.json", items.ToString());
                Console.WriteLine(items);
            }

            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
