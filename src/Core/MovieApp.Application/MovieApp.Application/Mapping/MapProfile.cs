using AutoMapper;
using MovieApp.Application.Dtos.TokenDtos;
using MovieApp.Domain.Entities.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Application.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<AppUser,AppUserDto>().ReverseMap();
        }
    }
}
