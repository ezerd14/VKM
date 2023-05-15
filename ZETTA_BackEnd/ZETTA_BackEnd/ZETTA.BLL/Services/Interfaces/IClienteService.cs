using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZETTA.BLL.DTO_s;
using ZETTA.DAL.Entities;

namespace ZETTA.BLL.Services.Interfaces
{
    public interface IClienteService
    {
        Task<IEnumerable<ClienteDto>> GetClientes();
        Task <ClienteDto> GetClienteById(int id);
        Task CreateCliente(ClienteDto clienteDto);
        Task UpdateCliente(ClienteDto clienteDto);
        Task DeleteCliente(int id);

    }
}
