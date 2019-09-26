using System;
using System.Collections.Generic;
using System.Text;

namespace FundApec.Entities
{
    public class Encabezado
    {
        public string Tipo_Registro { get; set; }
        public DateTime FechaTransmision { get; set; }
        public string PeriodoAcademico { get; set; }
        public string Tipo_Moneda { get; set; }
    }
}
