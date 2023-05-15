using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZETTA.DAL.Entities;
using ZETTA.DAL.Repositories.Interfaces;

namespace ZETTA.DAL.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly ApplicationDBContext _context;

        public ClienteRepository(ApplicationDBContext context)
        {
            _context = context;
        }



        public async Task<IEnumerable<Cliente>> GetClientes()
        {
            IEnumerable <Cliente> clientes= await _context.Clientes
                .Include(c=>c.Ciudad)
                .ToListAsync();
            return clientes ;
        }

        public async Task <Cliente> GetClienteById(int id)
        {
            Cliente cliente =  await _context.Clientes
                .Include(c=>c.Ciudad)
                .SingleOrDefaultAsync(c => c.Id == id);
            return cliente;
        }

        public async Task CreateCliente(Cliente cliente)
        {
            _context.Add(cliente);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateCliente(Cliente cliente)
        {
            Cliente clienteEdit = await _context.Clientes.FirstOrDefaultAsync(x => x.Id == cliente.Id);
            if (clienteEdit != null)
            {
                clienteEdit.Nombre = cliente.Nombre;
                clienteEdit.Apellido = cliente.Apellido;
                clienteEdit.CiudadId = cliente.CiudadId;
                clienteEdit.Domicilio = cliente.Domicilio;
                clienteEdit.Email = cliente.Email;
                clienteEdit.Password = cliente.Password;
                clienteEdit.Habilitado = cliente.Habilitado;
                await _context.SaveChangesAsync();
            }
        }

        public async Task DeleteCliente(int id)
        {
            Cliente cliente= await _context.Clientes.FindAsync(id);

            if (cliente != null)
            {
                _context.Clientes.Remove(cliente);
                await _context.SaveChangesAsync();
            }
            
        }

        
    }
}
