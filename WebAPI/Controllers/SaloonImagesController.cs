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
    public class SaloonImagesController : ControllerBase
    {
        ISaloonImageService _saloonImageService;

        public SaloonImagesController(ISaloonImageService saloonImageService)
        {
            _saloonImageService = saloonImageService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _saloonImageService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult AddSaloonImage(SaloonImage saloonImage)
        {
            var result = _saloonImageService.Add(saloonImage);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult UpdateSaloonImage(SaloonImage saloonImage)
        {
            var result = _saloonImageService.Update(saloonImage);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult DeleteSaloonImage(SaloonImage saloonImage)
        {
            var result = _saloonImageService.Delete(saloonImage);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
