using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZETTA.BLL.DTO_s
{
    public class ClienteDto
    {
        public int? Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Domicilio { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool Habilitado { get; set; }
        public int CiudadId { get; set; }
        public string? NombreCiudad { get; set; }
    }
}
