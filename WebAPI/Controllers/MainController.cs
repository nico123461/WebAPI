using Infrastructure.Models;
using Microsoft.AspNetCore.Mvc;
using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/redarbor")]
    public class MainController : Controller
    {
        private IEmployeeService employeeService;
        public MainController(IEmployeeService employeeService)
        {
            this.employeeService = employeeService;
        }

        [HttpGet]
        [ProducesResponseType(typeof(List<Employee>), 200)]
        public IActionResult GetAll()
        {
            try
            {
                return Ok(employeeService.GetAllEmployees());
            }
            catch(Exception ex)
            {
#if DEBUG
                return BadRequest(ex);
#else
                return BadRequest();
#endif
            }
        }
    }
}
