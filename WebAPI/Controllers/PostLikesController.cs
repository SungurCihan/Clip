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
    public class PostLikesController : ControllerBase
    {
        IPostLikeService _postLikeServicce;

        public PostLikesController(IPostLikeService postLikeServicce)
        {
            _postLikeServicce = postLikeServicce;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _postLikeServicce.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult AddPostComment(PostLike postLike)
        {
            var result = _postLikeServicce.Add(postLike);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult UpdatePostComment(PostLike postLike)
        {
            var result = _postLikeServicce.Update(postLike);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult DeletePostComment(PostLike postLike)
        {
            var result = _postLikeServicce.Delete(postLike);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
