using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using ZETTA.BLL.DTO_s;
using ZETTA.BLL.Services.Interfaces;

namespace ZETTA_BackEnd.Controllers
{
    [Route("login")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly ILoginService _loginService;
        private readonly IConfiguration _config;
        public LoginController(ILoginService loginService, IConfiguration config)
        {
            _loginService = loginService;
            _config = config;
        }

        [HttpPost("authenticate")]
        public async Task<IActionResult> Login(LoginDto loginDto)
        {
            var cliente= await _loginService.Login(loginDto);

            if (cliente == null)
            
                return BadRequest(new { mesage = "Credenciales Invalidas." });
            string jwtToken = GenerateToken(cliente);
            
            return Ok(new { token= jwtToken });
        }

        private string GenerateToken(ClienteDto cliente)
        {
            var claims = new[]
            {
                new Claim(ClaimTypes.Name, cliente.Nombre),
                new Claim(ClaimTypes.Email, cliente.Email),
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config.GetSection("JWT:Key").Value));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

            var securityToken = new JwtSecurityToken(
                                    claims: claims,
                                    expires: DateTime.Now.AddMinutes(1),
                                    signingCredentials: creds);
            string token= new JwtSecurityTokenHandler().WriteToken(securityToken);
            return token;
        }
    }
}
