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
    public class FolowersController : ControllerBase
    {
        IFolowerService _folowerService;

        public FolowersController(IFolowerService folowerService)
        {
            _folowerService = folowerService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _folowerService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult AddFolower(Folower folower)
        {
            var result = _folowerService.Add(folower);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult UpdateFolower(Folower folower)
        {
            var result = _folowerService.Update(folower);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult DeleteFolower(Folower folower)
        {
            var result = _folowerService.Delete(folower);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
