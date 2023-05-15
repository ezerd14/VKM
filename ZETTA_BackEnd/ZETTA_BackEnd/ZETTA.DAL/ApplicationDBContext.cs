using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZETTA.DAL.Configurations;
using ZETTA.DAL.Entities;

namespace ZETTA.DAL
{
    public class ApplicationDBContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Factura> Facturas { get; set; }
        public DbSet<Ciudad> Ciudades { get; set; }
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new ClienteConfigurations(modelBuilder.Entity<Cliente>());
            new FacturaConfigurations(modelBuilder.Entity<Factura>());
            new CiudadConfigurations(modelBuilder.Entity<Ciudad>());

            base.OnModelCreating(modelBuilder);
        }
    }
}
