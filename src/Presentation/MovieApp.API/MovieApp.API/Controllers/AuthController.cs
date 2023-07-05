using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieApp.Application.Dtos.TokenDtos;
using MovieApp.Application.Interfaces.IService;
using MovieApp.Domain.Entities.Identity;

namespace MovieApp.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AuthController : CustomBaseController
    {
        private readonly IAuthenticationService _authenticationServices;

        public AuthController(IAuthenticationService authenticationServices)
        {
            _authenticationServices = authenticationServices;
        }

        [HttpPost]
        public async Task<IActionResult> CreateToken(LoginDto loginDto)
        {
            var result = await _authenticationServices.CreateToken(loginDto);
            return ActionResultInctance(result);
        }

        [HttpPost]
        public async Task<IActionResult> RevokeRefreshToken(RefreshTokenDto refreshTokenDto)
        {
            var result = await _authenticationServices.RevokeRefreshToken(refreshTokenDto.RefreshToken);
            return ActionResultInctance(result);
        }

        [HttpPost]
        public async Task<IActionResult> CreateTokenByRefreshToken(RefreshTokenDto refreshTokenDto)
        {
           var result= await _authenticationServices.CreateTokenByRefreshToken(refreshTokenDto.RefreshToken);
            return ActionResultInctance(result);
        }




    }
}
