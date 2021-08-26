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
    public class EmployeeStarCountsController : ControllerBase
    {
        IEmployeeStarCountService _employeeStarCountService;

        public EmployeeStarCountsController(IEmployeeStarCountService employeeStarCountService)
        {
            _employeeStarCountService = employeeStarCountService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _employeeStarCountService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult AddEmployeeStarCount(EmployeeStarCount employeeStarCount)
        {
            var result = _employeeStarCountService.Add(employeeStarCount);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult UpdateEmployeeStarCount(EmployeeStarCount employeeStarCount)
        {
            var result = _employeeStarCountService.Update(employeeStarCount);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult DeleteEmployeeStarCount(EmployeeStarCount employeeStarCount)
        {
            var result = _employeeStarCountService.Delete(employeeStarCount);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
