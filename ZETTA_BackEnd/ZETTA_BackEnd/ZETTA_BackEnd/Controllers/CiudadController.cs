using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ZETTA.BLL.DTO_s;
using ZETTA.BLL.Services.Interfaces;

namespace ZETTA_BackEnd.Controllers
{
    [Route("ciudades")]
    [ApiController]
    public class CiudadController : ControllerBase
    {
        private readonly ICiudadService _ciudadService;
        public CiudadController(ICiudadService ciudadService)
        {
            _ciudadService = ciudadService;
        }

        [HttpGet]
        public async Task<IActionResult> GetCiudades()
        {
            IEnumerable<CiudadDto> ciudadesDto = await _ciudadService.GetCiudades();
            return Ok(ciudadesDto);
        }
    }
}
