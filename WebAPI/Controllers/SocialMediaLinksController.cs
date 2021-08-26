using Business.Abstract;
using Entity.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SocialMediaLinksController : ControllerBase
    {
        ISocialMediaLinkService _socialMediaLinkService;

        public SocialMediaLinksController(ISocialMediaLinkService socialMediaLinkService)
        {
            _socialMediaLinkService = socialMediaLinkService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _socialMediaLinkService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult AddSocialMediaLink(SocialMediaLink socialMediaLink)
        {
            var result = _socialMediaLinkService.Add(socialMediaLink);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult UpdateSocialMediaLink(SocialMediaLink socialMediaLink)
        {
            var result = _socialMediaLinkService.Update(socialMediaLink);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult DeleteSocialMediaLink(SocialMediaLink socialMediaLink)
        {
            var result = _socialMediaLinkService.Delete(socialMediaLink);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
