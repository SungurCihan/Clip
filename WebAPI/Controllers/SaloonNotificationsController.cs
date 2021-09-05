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
    public class SaloonNotificationsController : ControllerBase
    {
        ISaloonNotificationService _saloonNotificationService;

        public SaloonNotificationsController(ISaloonNotificationService saloonNotificationService)
        {
            _saloonNotificationService = saloonNotificationService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _saloonNotificationService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult AddAppointment(SaloonNotification saloonNotification)
        {
            var result = _saloonNotificationService.Add(saloonNotification);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult UpdateAppointment(SaloonNotification saloonNotification)
        {
            var result = _saloonNotificationService.Update(saloonNotification);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult DeleteAppointment(SaloonNotification saloonNotification)
        {
            var result = _saloonNotificationService.Delete(saloonNotification);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
