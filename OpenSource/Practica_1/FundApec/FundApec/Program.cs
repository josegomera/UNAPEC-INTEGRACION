using FundApec.Entities;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;

namespace FundApec
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Encabezado> encabezado = new List<Encabezado>
            {
               new Encabezado { Tipo_Registro = "D", FechaTransmision = DateTime.UtcNow.AddMinutes(-240), PeriodoAcademico = "2019-3", Tipo_Moneda = "DOP"}
            };
            List<Detalle> detalle = new List<Detalle>
            {
                new Detalle { Tipo_Registro = "E", Matricula = "2017-1497", Cedula = "402-2315799-7", CantidadCreditos = 5, Monto = 30000},
                new Detalle { Tipo_Registro = "E", Matricula = "2017-1158", Cedula = "402-2318699-5", CantidadCreditos = 6, Monto = 45000},
                new Detalle { Tipo_Registro = "E", Matricula = "2017-1111", Cedula = "225-2455799-0", CantidadCreditos = 3, Monto = 25000},
                new Detalle { Tipo_Registro = "E", Matricula = "2017-2268", Cedula = "223-2308087-6", CantidadCreditos = 8, Monto = 60000}
            };
            Sumario sumario = new Sumario
            {
                cantidadEstudiantes = 4,
                TotalCreditos = 22,
                MontoTotal = 160000
            };

            var data = new JObject
            {
                encabezado,
                detalle,
                sumario
            };

            var jsonData = JsonConvert.SerializeObject(data);

            System.IO.File.WriteAllText(@"C:\temp\file.json", jsonData.ToString());

            Console.WriteLine(jsonData);

            Console.ReadKey();
        }
    }
}
