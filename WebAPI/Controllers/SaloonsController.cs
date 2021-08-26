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
    public class SaloonsController : ControllerBase
    {
        ISaloonService _saloonService;

        public SaloonsController(ISaloonService saloonService)
        {
            _saloonService = saloonService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _saloonService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult AddSaloon(Saloon saloon)
        {
            var result = _saloonService.Add(saloon);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult UpdateSaloon(Saloon saloon)
        {
            var result = _saloonService.Update(saloon);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult DeleteSaloon(Saloon saloon)
        {
            var result = _saloonService.Delete(saloon);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
