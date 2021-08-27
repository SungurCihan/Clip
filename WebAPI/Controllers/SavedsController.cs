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
    public class SavedsController : ControllerBase
    {
        ISavedService _savedService;

        public SavedsController(ISavedService savedService)
        {
            _savedService = savedService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _savedService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult AddSaved(Saved saved)
        {
            var result = _savedService.Add(saved);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult UpdateSaved(Saved saved)
        {
            var result = _savedService.Update(saved);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult DeleteSaved(Saved saved)
        {
            var result = _savedService.Delete(saved);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
