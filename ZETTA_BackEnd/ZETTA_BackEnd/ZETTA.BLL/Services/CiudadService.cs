using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZETTA.BLL.DTO_s;
using ZETTA.BLL.Services.Interfaces;
using ZETTA.DAL.Entities;
using ZETTA.DAL.Repositories.Interfaces;

namespace ZETTA.BLL.Services
{
    public class CiudadService : ICiudadService
    {
        private readonly ICiudadRepository _ciudadRepository;
        private IMapper _mapper;
        public CiudadService(ICiudadRepository ciudadRepository, IMapper mapper)
        {
            _ciudadRepository = ciudadRepository;
            _mapper = mapper;
        }


        public async Task<IEnumerable<CiudadDto>> GetCiudades()
        {

            IEnumerable<Ciudad> ciudades = await _ciudadRepository.GetCiudades();
            var ciudadesDto = _mapper.Map<IEnumerable<CiudadDto>>(ciudades);
            return (ciudadesDto);
        }
    }
}
