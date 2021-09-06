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
    public class SaloonProfilePhotosController : ControllerBase
    {
        ISaloonProfilePhotoService _saloonProfilePhotoService;

        public SaloonProfilePhotosController(ISaloonProfilePhotoService saloonProfilePhotoService)
        {
            _saloonProfilePhotoService = saloonProfilePhotoService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _saloonProfilePhotoService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult AddAppointment(SaloonProfilePhoto saloonProfilePhoto)
        {
            var result = _saloonProfilePhotoService.Add(saloonProfilePhoto);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult UpdateAppointment(SaloonProfilePhoto saloonProfilePhoto)
        {
            var result = _saloonProfilePhotoService.Update(saloonProfilePhoto);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult DeleteAppointment(SaloonProfilePhoto saloonProfilePhoto)
        {
            var result = _saloonProfilePhotoService.Delete(saloonProfilePhoto);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
