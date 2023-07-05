using MovieApp.Application.Dtos.TokenDtos;
using MovieApp.Domain.Entities.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Application.Interfaces.IService
{
    public interface ITokenService
    {
        TokenDto CreateToken(AppUser appUser);
    }
}
