using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ZETTA.BLL.DTO_s;
using ZETTA.BLL.Services;
using ZETTA.BLL.Services.Interfaces;

namespace ZETTA_BackEnd.Controllers
{
    //[Authorize]
    [Route("facturas")]
    [ApiController]
    public class FacturaController : ControllerBase
    {
        private readonly IFacturaService _facturaService;
        public FacturaController( IFacturaService facturaService)
        {
            _facturaService = facturaService;
        }

        [HttpGet]
        public async Task<IActionResult> GetFacturas()
        {
            IEnumerable<FacturaDto> facturasDto = await _facturaService.GetFacturas();
            return Ok(facturasDto);
        }


        [HttpPost]
        public async Task<IActionResult> CreateFactura(FacturaDto facturaDto)
        {
            try
            {
                await _facturaService.CreateFactura(facturaDto);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetFacturaById(int id)
        {
            try
            {
                FacturaDto facturaDto = await _facturaService.GetFacturaById(id);
                if (facturaDto == null)
                {
                    return NotFound();
                }
                return Ok(facturaDto);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
