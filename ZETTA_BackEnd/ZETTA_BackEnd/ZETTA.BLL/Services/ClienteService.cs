using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZETTA.BLL.DTO_s;
using ZETTA.BLL.Services.Interfaces;
using ZETTA.DAL.Entities;
using ZETTA.DAL.Repositories.Interfaces;

namespace ZETTA.BLL.Services
{
    public class ClienteService :IClienteService
    {
        private readonly IClienteRepository _clienteRepository;
        private IMapper _mapper;
        public ClienteService( IClienteRepository clienteRepository, IMapper mapper)
        {
            _clienteRepository = clienteRepository;
            _mapper = mapper;
        }


        public async Task<IEnumerable<ClienteDto>> GetClientes()
        {

            IEnumerable<Cliente> clientes = await _clienteRepository.GetClientes();
            var clientesDto = _mapper.Map<IEnumerable<ClienteDto>>(clientes);
            return (clientesDto);
        }

        public async Task <ClienteDto> GetClienteById(int id)
        {
            Cliente cliente = await _clienteRepository.GetClienteById(id);
            return _mapper.Map<ClienteDto>(cliente);
        }


        public async Task CreateCliente(ClienteDto clienteDto)
        {
            Cliente cliente = _mapper.Map<Cliente>(clienteDto);
            await _clienteRepository.CreateCliente(cliente);
        }

        public async Task UpdateCliente(ClienteDto clienteDto)
        {
            Cliente cliente = _mapper.Map<Cliente>(clienteDto);
            await _clienteRepository.UpdateCliente(cliente);
        }


        public async Task DeleteCliente(int id)
        {
            await _clienteRepository.DeleteCliente(id); 
        }

    }
}
