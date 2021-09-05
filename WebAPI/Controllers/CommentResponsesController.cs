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
    public class CommentResponsesController : ControllerBase
    {
        ICommentResponseService _commentResponseService;

        public CommentResponsesController(ICommentResponseService commentResponseService)
        {
            _commentResponseService = commentResponseService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _commentResponseService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult AddAppointment(CommentResponse commentResponse)
        {
            var result = _commentResponseService.Add(commentResponse);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult UpdateAppointment(CommentResponse commentResponse)
        {
            var result = _commentResponseService.Update(commentResponse);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult DeleteAppointment(CommentResponse commentResponse)
        {
            var result = _commentResponseService.Delete(commentResponse);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
