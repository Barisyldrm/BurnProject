using AutoMapper;
using Burn.DtoLayer.AboutDto;
using Burn.EntityLayer.Entities;
using Microsoft.AspNetCore.Mvc;

namespace BurnApi.Mapping
{
    public class AboutMapping:Profile
    {
        public AboutMapping()
        {
            CreateMap<About, ResultAboutDto>().ReverseMap();
            CreateMap<About, CreateAboutDto>().ReverseMap();
            CreateMap<About, GetAboutDto>().ReverseMap();
            CreateMap<About, UpdateAboutDto>().ReverseMap();
                
        }
    }
}
