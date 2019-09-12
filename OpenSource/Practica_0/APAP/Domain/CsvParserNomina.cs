using APAP.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using TinyCsvParser.Mapping;

namespace APAP.Domain
{
    public class CsvParserNomina : CsvMapping<Nomina>
    {
        public CsvParserNomina() : base()
        {
            MapProperty(0, x => x.TipoRegistro);
            MapProperty(1, x => x.ClaveNomina);
            MapProperty(2, x => x.TipoDocumento);
            MapProperty(3, x => x.NoDocumento);
            MapProperty(4, x => x.MontoPagar);
            MapProperty(5, x => x.Cuenta);
        }
    }
}









