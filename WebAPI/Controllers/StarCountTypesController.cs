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
    public class StarCountTypesController : ControllerBase
    {
        IStarCountTypeService _starCountTypeService;

        public StarCountTypesController(IStarCountTypeService starCountTypeService)
        {
            _starCountTypeService = starCountTypeService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _starCountTypeService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult AddAppointment(StarCountType starCountType)
        {
            var result = _starCountTypeService.Add(starCountType);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult UpdateAppointment(StarCountType starCountType)
        {
            var result = _starCountTypeService.Update(starCountType);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult DeleteAppointment(StarCountType starCountType)
        {
            var result = _starCountTypeService.Delete(starCountType);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
