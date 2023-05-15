using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZETTA.DAL.Entities;

namespace ZETTA.BLL.DTO_s.Mappings
{
    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Cliente, ClienteDto>()
            .ForMember(c => c.NombreCiudad, opt => opt.MapFrom(c => c.Ciudad.Nombre));
            CreateMap<ClienteDto, Cliente>();


            CreateMap<Ciudad, CiudadDto>();
            CreateMap<CiudadDto, Ciudad>();


            CreateMap<Factura, FacturaDto>()
                .ForMember(f => f.NombreCliente, opt => opt.MapFrom(f => f.Cliente.Nombre));
            CreateMap<FacturaDto, Factura>();


            CreateMap<Cliente, LoginDto>();
            CreateMap<LoginDto, Cliente>();
        }
    }
}
