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
    public class SaloonCommentsController : ControllerBase
    {
        ISaloonCommentService _saloonCommentService;

        public SaloonCommentsController(ISaloonCommentService saloonCommentService)
        {
            _saloonCommentService = saloonCommentService;
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _saloonCommentService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult AddSaloonComment(SaloonComment saloonComment)
        {
            var result = _saloonCommentService.Add(saloonComment);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult UpdateSaloonComment(SaloonComment saloonComment)
        {
            var result = _saloonCommentService.Update(saloonComment);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult DeleteSaloonComment(SaloonComment saloonComment)
        {
            var result = _saloonCommentService.Delete(saloonComment);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
