using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZETTA.BLL.DTO_s;
using ZETTA.BLL.Services.Interfaces;
using ZETTA.DAL.Entities;
using ZETTA.DAL.Repositories;
using ZETTA.DAL.Repositories.Interfaces;

namespace ZETTA.BLL.Services
{
    public class FacturaService: IFacturaService
    {
        private readonly IFacturaRepository _facturaRepository;
        private IMapper _mapper;
        public FacturaService(IFacturaRepository facturaRepository, IMapper mapper)
        {
            _facturaRepository = facturaRepository;
            _mapper = mapper;
        }


        public async Task<IEnumerable<FacturaDto>> GetFacturas()
        {

            IEnumerable<Factura> facturas = await _facturaRepository.GetFacturas();
            var facturasDto = _mapper.Map<IEnumerable<FacturaDto>>(facturas);
            return (facturasDto);
        }

        public async Task CreateFactura(FacturaDto facturaDto)
        {
            Factura factura = _mapper.Map<Factura>(facturaDto);
            factura.Fecha= DateTime.Now;
            await _facturaRepository.CreateFactura(factura);
        }

        public async Task<FacturaDto> GetFacturaById(int id)
        {
            Factura factura = await _facturaRepository.GetFacturaById(id);
            return _mapper.Map<FacturaDto>(factura);
        }

    }
}
