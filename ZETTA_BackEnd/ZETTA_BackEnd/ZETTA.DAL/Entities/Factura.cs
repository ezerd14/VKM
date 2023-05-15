using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZETTA.DAL.Entities
{
    public class Factura
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public string Detalle { get; set; }
        public decimal Importe { get; set; }

        public Cliente Cliente { get; set; }
        public int ClienteId { get; set; }
    }
}
