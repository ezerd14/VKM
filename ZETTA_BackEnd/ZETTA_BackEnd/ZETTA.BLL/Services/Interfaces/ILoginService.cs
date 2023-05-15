using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZETTA.BLL.DTO_s;

namespace ZETTA.BLL.Services.Interfaces
{
    public interface ILoginService
    {
        Task <ClienteDto> Login(LoginDto loginDto);

    }
}
