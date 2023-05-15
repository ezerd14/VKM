using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZETTA.BLL.DTO_s
{
    public class FacturaDto
    {
        public int Id { get; set; }
        public string Detalle { get; set; }
        public decimal Importe { get; set; }
        public int ClienteId { get; set; }
        public string? NombreCliente { get; set; }
    }
}
