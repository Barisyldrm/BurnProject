﻿using AutoMapper;
using Burn.BusinessLayer.Abstract;
using Burn.DtoLayer.CategoryDto;
using Burn.DtoLayer.ContactDto;
using Burn.EntityLayer.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BurnApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IContactService _contactService;
        private readonly IMapper _mapper;

        public ContactController(IContactService contactService, IMapper mapper)
        {
            _contactService = contactService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult ContactList()
        {
            var value = _mapper.Map<List<ResultContactDto>>(_contactService.TGetAll());
            return Ok(value);
        }
        [HttpPost]
        public IActionResult CreateContact(CreateContactDto createContactDto)
        {
            _contactService.TAdd(new Contact()
            {
              FooterDescription = createContactDto.FooterDescription,
              Location = createContactDto.Location,
              Mail=createContactDto.Mail,
              Phone=createContactDto.Phone,

            });
            return Ok("İletişim Bilgisi eklendi");
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteContact(int id)
        {
            var value = _contactService.TGetByID(id);
            _contactService.TDelete(value);
            return Ok("İletişim Bilgisi silindi");
        }
        [HttpGet("{id}")]
        public IActionResult GetContact(int id)
        {
            var value = _contactService.TGetByID(id);
            return Ok(value);
        }
        [HttpPut]
        public IActionResult UpdateContact(UpdateContactDto updateContactDto)
        {
            _contactService.TUpdate(new Contact()
            {
             ContactID = updateContactDto.ContactID,
             FooterDescription=updateContactDto.FooterDescription,
             Location = updateContactDto.Location,  
             Mail=updateContactDto.Mail,
             Phone=updateContactDto.Phone,
            });
            return Ok("İletişim Bilgisi güncellendi");
        }
    }
}
