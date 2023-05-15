using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZETTA.DAL.Entities;

namespace ZETTA.DAL.Configurations
{
    public class FacturaConfigurations
    {
        public FacturaConfigurations(EntityTypeBuilder<Factura> entityBuilder)
        {
            entityBuilder.Property(f => f.Detalle).HasMaxLength(200).IsRequired();
            entityBuilder.Property(f => f.Fecha).IsRequired();
            entityBuilder.Property(f => f.Importe).HasPrecision(18, 4).IsRequired();
        }
    }
}
