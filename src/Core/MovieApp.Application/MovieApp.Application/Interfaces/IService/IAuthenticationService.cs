using MovieApp.Application.Dtos.CustomResponseDtos;
using MovieApp.Application.Dtos.TokenDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Application.Interfaces.IService
{
    public interface IAuthenticationService
    {
        Task<ResponseDto<TokenDto>> CreateToken(LoginDto loginDto);
        Task<ResponseDto<TokenDto>> CreateTokenByRefreshToken(string refreshToken);
        Task<ResponseDto<NoContentDto>> RevokeRefreshToken(string refreshToken);
    }
}
