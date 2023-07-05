using MovieApp.Application.Dtos.CustomResponseDtos;
using MovieApp.Application.Dtos.TokenDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Application.Interfaces.IService
{
    public interface IUserService
    {
        Task<ResponseDto<AppUserDto>> CreateUserAsync(CreateUserDto createUserDto);
        Task<ResponseDto<AppUserDto>> GetUserNameAsync(string userName);
    }
}
