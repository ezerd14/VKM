﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZETTA.BLL.DTO_s;

namespace ZETTA.BLL.Services.Interfaces
{
    public interface IFacturaService
    {
        Task<IEnumerable<FacturaDto>> GetFacturas();
        Task CreateFactura(FacturaDto facturaDto);
        Task<FacturaDto> GetFacturaById(int id);
    }
}
