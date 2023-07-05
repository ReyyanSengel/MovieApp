using AutoMapper;
using Microsoft.AspNetCore.Identity;
using MovieApp.Application.Dtos.CustomResponseDtos;
using MovieApp.Application.Dtos.TokenDtos;
using MovieApp.Application.Interfaces.IService;
using MovieApp.Domain.Entities.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Infrastructure.Services
{
    public class UserServise : IUserService
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly IMapper _mapper;

        public UserServise(UserManager<AppUser> userManager, IMapper mapper)
        {
            _userManager = userManager;
            _mapper = mapper;
        }

        public async Task<ResponseDto<AppUserDto>> CreateUserAsync(CreateUserDto createUserDto)
        {
            var user = new AppUser
            {
                Email = createUserDto.Email,
                UserName = createUserDto.UserName,
            };
            var result = await _userManager.CreateAsync(user, createUserDto.Password);
            if (!result.Succeeded)
            {
                var errors = result.Errors.Select(x => x.Description).ToList();
                return ResponseDto<AppUserDto>.Fail(new ErrorDto(errors, true), 400);
            }

            return ResponseDto<AppUserDto>.Success(_mapper.Map<AppUserDto>(user), 200);
        }

        public async Task<ResponseDto<AppUserDto>> GetUserNameAsync(string userName)
        {
            var user = await _userManager.FindByNameAsync(userName);
            if (user == null)
            {
                return ResponseDto<AppUserDto>.Fail("UserName not found", 404, true);
            }
            return ResponseDto<AppUserDto>.Success(_mapper.Map<AppUserDto>(user), 200);
        }
    }
}
