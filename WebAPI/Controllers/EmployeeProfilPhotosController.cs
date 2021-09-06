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
    public class EmployeeProfilPhotosController : ControllerBase
    {
        IEmployeeProfilePhotoService _employeeProfilPhotoService;

        public EmployeeProfilPhotosController(IEmployeeProfilePhotoService employeeProfilPhotoService)
        {
            _employeeProfilPhotoService = employeeProfilPhotoService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _employeeProfilPhotoService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult AddAppointment(EmployeeProfilePhoto employeeProfilePhoto)
        {
            var result = _employeeProfilPhotoService.Add(employeeProfilePhoto);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult UpdateAppointment(EmployeeProfilePhoto employeeProfilePhoto)
        {
            var result = _employeeProfilPhotoService.Update(employeeProfilePhoto);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult DeleteAppointment(EmployeeProfilePhoto employeeProfilePhoto)
        {
            var result = _employeeProfilPhotoService.Delete(employeeProfilePhoto);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
