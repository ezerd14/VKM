using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZETTA.DAL.Entities;

namespace ZETTA.DAL.Configurations
{
    public class CiudadConfigurations
    {
        public CiudadConfigurations(EntityTypeBuilder<Ciudad> entityBuilder)
        {
            entityBuilder.Property(c => c.Nombre).HasMaxLength(50).IsRequired();
        }
    }
}
