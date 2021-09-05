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
    public class SystemNotificationsController : ControllerBase
    {
        ISystemNotificationService _systemNotificationService;

        public SystemNotificationsController(ISystemNotificationService notificationService)
        {
            _systemNotificationService = notificationService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _systemNotificationService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult AddAppointment(SystemNotification systemNotification)
        {
            var result = _systemNotificationService.Add(systemNotification);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult UpdateAppointment(SystemNotification systemNotification)
        {
            var result = _systemNotificationService.Update(systemNotification);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult DeleteAppointment(SystemNotification systemNotification)
        {
            var result = _systemNotificationService.Delete(systemNotification);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
