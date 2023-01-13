using App1.Controllers.DTOs;
using App1.DTOs;
using App1.Entities;
using App1.Extensions;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App1.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<AppUser, MemberDto>()
              .ForMember(dest => dest.PhotoUrl, opt => opt.MapFrom(src =>
                  src.Photos.FirstOrDefault(x => x.IsMain).Url))
              .ForMember(dest => dest.Age, opt => opt.MapFrom(src => src.DateOfBirth.CalculateAge()));
            CreateMap<Photo, PhotoDto>();
            CreateMap<MemberUpdateDto, AppUser>();
            CreateMap<RegisterDto, AppUser>();
        }
    }
}
