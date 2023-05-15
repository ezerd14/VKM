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
    public class CiudadRepository : ICiudadRepository
    {
        private readonly ApplicationDBContext _context;

        public CiudadRepository(ApplicationDBContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Ciudad>> GetCiudades()
        {

            return await _context.Ciudades.ToListAsync();
        }
    }
}
