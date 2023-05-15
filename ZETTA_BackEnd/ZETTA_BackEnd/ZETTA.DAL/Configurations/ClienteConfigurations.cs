using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZETTA.DAL.Entities;

namespace ZETTA.DAL.Configurations
{
    public class ClienteConfigurations
    {
        public ClienteConfigurations(EntityTypeBuilder<Cliente> entityBuilder)
        {
            entityBuilder.Property(c => c.Nombre).HasMaxLength(50).IsRequired();
            entityBuilder.Property(c => c.Apellido).HasMaxLength(50).IsRequired();
            entityBuilder.Property(c => c.Domicilio).HasMaxLength(50).IsRequired();
            entityBuilder.Property(c => c.Domicilio).HasMaxLength(50).IsRequired();
            entityBuilder.Property(c => c.Email).HasMaxLength(100).IsRequired();
            entityBuilder.Property(c => c.Password).HasMaxLength(100).IsRequired();
        }
    }
}
