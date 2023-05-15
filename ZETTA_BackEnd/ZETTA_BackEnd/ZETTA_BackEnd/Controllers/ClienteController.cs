using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ZETTA.BLL.DTO_s;
using ZETTA.BLL.Services.Interfaces;

namespace ZETTA_BackEnd.Controllers
{
    //[Authorize]
    [Route("clientes")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteService _clienteService;
        public ClienteController(IClienteService clienteService)
        {
            _clienteService = clienteService;
        }

        [HttpGet]
        public async Task<IActionResult> GetClientes()
        {
            IEnumerable <ClienteDto> clientesDto= await _clienteService.GetClientes();
            return Ok(clientesDto);
        }


        [HttpGet("{id}")]
        public async Task <IActionResult> GetClienteById(int id)
        {
            try
            {
                ClienteDto clienteDto = await _clienteService.GetClienteById(id);
                if (clienteDto == null)
                {
                    return NotFound();
                }
                return Ok(clienteDto);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpPost]
        public async Task<IActionResult> CreateCliente(ClienteDto clienteDto)
        {
            try
            {
                await _clienteService.CreateCliente(clienteDto);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpPut]
        public async Task<IActionResult> UpdateCliente(ClienteDto clienteDto)
        {
            try
            {
                await _clienteService.UpdateCliente(clienteDto);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCliente(int id)
        {
            try
            {
                await _clienteService.DeleteCliente(id);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
