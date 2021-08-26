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
    public class StoriesController : ControllerBase
    {
        IStoryService _storyService;

        public StoriesController(IStoryService storyService)
        {
            _storyService = storyService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _storyService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult AddStory(Story story)
        {
            var result = _storyService.Add(story);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult UpdateStory(Story story)
        {
            var result = _storyService.Update(story);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult DeleteStory(Story story)
        {
            var result = _storyService.Delete(story);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
