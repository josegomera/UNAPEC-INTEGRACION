using System;
using System.Collections.Generic;
using System.Text;

namespace APAP.Entities
{
    public class Nomina
    {
        public int Id { get; set; }
        public string TipoRegistro { get; set; }
        public string ClaveNomina { get; set; }
        public string TipoDocumento { get; set; }
        public string NoDocumento { get; set; }
        public decimal MontoPagar { get; set; }
        public string Cuenta { get; set; }
    }
}
