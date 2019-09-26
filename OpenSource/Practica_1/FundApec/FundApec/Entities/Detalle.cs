using System;
using System.Collections.Generic;
using System.Text;

namespace FundApec.Entities
{
    public class Detalle
    {
        public string Tipo_Registro { get; set; }
        public string Matricula { get; set; }
        public string Cedula { get; set; }
        public int CantidadCreditos { get; set; }
        public decimal Monto { get; set; }
    }
}
