using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using VogCodeChallenge.API.Models;
using VogCodeChallenge.API.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace VogCodeChallenge.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeesController : Controller
    {
        private readonly ILogger<EmployeesController> _logger;
        private readonly EmployeeService _employeeService;
        private readonly DepartmentService _departmentService;

        public EmployeesController(ILogger<EmployeesController> logger, EmployeeService employeeService, DepartmentService departmentService)
        {
            _logger = logger;
            _employeeService = employeeService;
            _departmentService = departmentService;
        }

        [HttpGet]
        public ActionResult<List<Employee>> Index()
        {
            return (List<Employee>)_employeeService.ListAll();
        }

        [HttpGet("department/{departmentId}")]
        public ActionResult<Department> Department(string departmentId)
        {
            var dep = _departmentService.Find(departmentId);

            if (dep == null) return NotFound();

            return dep;
        }
    }
}
