using Ems.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;
using Services;

namespace Employe_Management_System.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class EmployeController : ControllerBase
    {
        private readonly EmployeeServices employeeServices;
        public EmployeController(EmployeeServices employeeServices)
        {
            this.employeeServices = employeeServices;
        }
        [HttpGet]
        public List<Employee> GetEmployees()
        {
            return employeeServices.GetEmployeeDetails();
        }
        [HttpPost]
        public string AddEmployee(Employee employee)
        {
            return employeeServices.AddEmployee(employee);
        }
        [HttpGet]
        public List<Employee> GetEmployeById(string id)
        {
            return employeeServices.GetEmployeById(id);
        }
        
    }
}
