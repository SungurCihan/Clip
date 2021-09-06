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
    public class ProfilePhotosController : ControllerBase
    {
        IProfilePhotoService _profilPhotoService;

        public ProfilePhotosController(IProfilePhotoService profilPhotoService)
        {
            _profilPhotoService = profilPhotoService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _profilPhotoService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult AddAppointment(ProfilePhoto profilePhoto)
        {
            var result = _profilPhotoService.Add(profilePhoto);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult UpdateAppointment(ProfilePhoto profilePhoto)
        {
            var result = _profilPhotoService.Update(profilePhoto);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult DeleteAppointment(ProfilePhoto profilePhoto)
        {
            var result = _profilPhotoService.Delete(profilePhoto);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
