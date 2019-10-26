using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _3thPartySoftware.Entities
{
    public class AsientoExterno
    {
        [Key]
        public int IdAsiento { get; set; }
        public int Id { get; set; }
        public string NoAsiento { get; set; }
        public string Description { get; set; }
        public DateTime Fecha { get; set; }
        public string Cuenta { get; set; }
        public TipoMovimiento TipoMovimiento { get; set; }
        public decimal MontoMovimiento { get; set; }
    }

    public enum TipoMovimiento
    {
        CR,
        DB
    }
}
