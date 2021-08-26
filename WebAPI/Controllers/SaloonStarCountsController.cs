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
    public class SaloonStarCountsController : ControllerBase
    {
        ISaloonStarCountService _saloonStarCountService;

        public SaloonStarCountsController(ISaloonStarCountService saloonStarCountService)
        {
            _saloonStarCountService = saloonStarCountService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _saloonStarCountService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult AddSaloonStarCount(SaloonStarCount saloonStarCount)
        {
            var result = _saloonStarCountService.Add(saloonStarCount);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult UpdateSaloonStarCount(SaloonStarCount saloonStarCount)
        {
            var result = _saloonStarCountService.Update(saloonStarCount);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult DeleteSaloonStarCount(SaloonStarCount saloonStarCount)
        {
            var result = _saloonStarCountService.Delete(saloonStarCount);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
