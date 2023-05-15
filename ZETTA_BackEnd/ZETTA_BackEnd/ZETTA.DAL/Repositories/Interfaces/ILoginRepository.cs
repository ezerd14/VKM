using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZETTA.DAL.Entities;

namespace ZETTA.DAL.Repositories.Interfaces
{
    public interface ILoginRepository
    {
        Task<Cliente> GetClienteRegistrated(string email, string password);

    }
}
