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
    public class LoginRepository : ILoginRepository
    {
        private readonly ApplicationDBContext _context;

        public LoginRepository(ApplicationDBContext context)
        {
            _context = context;
        }

        public async Task<Cliente> GetClienteRegistrated(string email, string password)
        {
            Cliente clienteRegistrated = await _context.Clientes.
                SingleOrDefaultAsync(c => c.Email == email && c.Password == password);
            return clienteRegistrated;
        }
    }
}
