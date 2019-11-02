using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cuentas_x_Cobrar_Carol.Entities
{
    public class Factura
    {
        public int Id { get; set; }
        public string Cliente { get; set; }
        public string Vendedor { get; set; }
        public string Producto { get; set; }
        public decimal Valor { get; set; }
        public TipoTransaccion TipoTransaccion { get; set; }

    }

    public enum TipoTransaccion
    {
        CR = 1,
        DB = 2
    }
}
