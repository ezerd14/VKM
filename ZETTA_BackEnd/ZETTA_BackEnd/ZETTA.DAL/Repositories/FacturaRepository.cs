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
    public class FacturaRepository : IFacturaRepository
    {
        private readonly ApplicationDBContext _context;

        public FacturaRepository(ApplicationDBContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Factura>> GetFacturas()
        {
            IEnumerable<Factura> facturas = await _context.Facturas
                .Include(f => f.Cliente)
                .ToListAsync();
            return facturas;
        }

        public async Task CreateFactura(Factura factura)
        {
            _context.Add(factura);
            await _context.SaveChangesAsync();
        }

        public async Task<Factura> GetFacturaById(int id)
        {
            Factura factura = await _context.Facturas
                .Include(f => f.Cliente)
                .SingleOrDefaultAsync(c => c.Id == id);
            return factura;
        }

    }
}
