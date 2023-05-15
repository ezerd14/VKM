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
    public class LoginService : ILoginService
    {
        private readonly ILoginRepository _loginRepository;
        private IMapper _mapper;
        public LoginService(ILoginRepository loginRepository, IMapper mapper)
        {
            _loginRepository = loginRepository;
            _mapper = mapper;
        }


        public async Task <ClienteDto> Login(LoginDto loginDto)
        {
            Cliente clienteRegistrated= await _loginRepository.GetClienteRegistrated(loginDto.Email, loginDto.Password);
            var clienteRegistratedDto = _mapper.Map<ClienteDto>(clienteRegistrated);
            return clienteRegistratedDto;
        }
    }
}
