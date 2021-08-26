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
    public class PostCommentsController : ControllerBase
    {
        IPostCommentService _postCommentServicce;

        public PostCommentsController(IPostCommentService postCommentServicce)
        {
            _postCommentServicce = postCommentServicce;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _postCommentServicce.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult AddPostComment(PostComment postComment)
        {
            var result = _postCommentServicce.Add(postComment);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult UpdatePostComment(PostComment postComment)
        {
            var result = _postCommentServicce.Update(postComment);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult DeletePostComment(PostComment postComment)
        {
            var result = _postCommentServicce.Delete(postComment);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
