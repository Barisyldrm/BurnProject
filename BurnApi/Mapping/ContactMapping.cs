﻿using AutoMapper;
using Burn.DtoLayer.ContactDto;
using Burn.EntityLayer.Entities;

namespace BurnApi.Mapping
{
    public class ContactMapping:Profile
    {
        public ContactMapping()
        {
            CreateMap<Contact,ResultContactDto>().ReverseMap();
            CreateMap<Contact,CreateContactDto>().ReverseMap();
            CreateMap<Contact,GetContactDto>().ReverseMap();
            CreateMap<Contact,UpdateContactDto>().ReverseMap();
        }
    }
}
