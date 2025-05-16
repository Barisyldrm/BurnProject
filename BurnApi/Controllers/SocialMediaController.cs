using AutoMapper;
using Burn.BusinessLayer.Abstract;
using Burn.DtoLayer.SocialMediaDto;
using Burn.DtoLayer.TestimonialDto;
using Burn.EntityLayer.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BurnApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SocialMediaController : ControllerBase
    {
        private readonly ISocialMediaService _socialMediaService;
        private readonly IMapper _mapper;

        public SocialMediaController(ISocialMediaService socialMediaService, IMapper mapper)
        {
            _socialMediaService = socialMediaService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult SocialMedialList()
        {
            var value = _mapper.Map<List<ResultSocialMediaDto>>(_socialMediaService.TGetAll());
            return Ok(value);
        }
        [HttpPost]
        public IActionResult CreateSocialMedia(CreateSocialMediaDto createSocialMediaDto)
        {
            _socialMediaService.TAdd(new SocialMedia()
            {
               Icon=createSocialMediaDto.Icon,
               Title=createSocialMediaDto.Title,
               Url=createSocialMediaDto.Url,
            });
            return Ok("Sosyal Media  Bilgisi eklendi");
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteSocialMedia(int id)
        {
            var value = _socialMediaService.TGetByID(id);
            _socialMediaService.TDelete(value);
            return Ok("Sosyal Media Bilgisi silindi");
        }
        [HttpGet("{id}")]
        public IActionResult GetSocialMedial(int id)
        {
            var value = _socialMediaService.TGetByID(id);
            return Ok(value);
        }
        [HttpPut]
        public IActionResult UpdateSocialMedia(UpdateSocialMediaDto updateSocialMediaDto)
        {
            _socialMediaService.TUpdate(new SocialMedia()
            {
                Url = updateSocialMediaDto.Url,
                Icon=updateSocialMediaDto.Icon,
                Title=updateSocialMediaDto.Title,
                SocialMediaID=updateSocialMediaDto.SocialMediaID,
            });
            return Ok("Sosyal Media Bilgisi güncellendi");
        }
    }
}
