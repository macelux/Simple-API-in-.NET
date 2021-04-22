using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using sampleApu.EmployeeData;
using sampleApu.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace sampleApu.Controllers
{
   
    [ApiController]
    public class EmployeesController : Controller
    {

        private IEmployeeRespository _employeeInterface;

        public EmployeesController(IEmployeeRespository employeeRepository) {
            _employeeInterface = employeeRepository;
        }


        /**
         *  Get employees
         */
       [HttpGet]
        [Route("api/[controller]")]
        public IActionResult GetEmployees()
        {
            return Ok( _employeeInterface.GetEmployees());
        }


        /**
       *  Get single employee
       */
        [HttpGet]
        [Route("api/[controller]/{id}")]
        public IActionResult GetEmployee(Guid id)
        {
            var employee = _employeeInterface.GetEmployee(id);

            if(employee != null)
            {
                return Ok(employee);
            }

            return NotFound($"the id {id} you are trying to call does not exist");
        }


        /**
       *  store an employee
       */
        [HttpPost]
        [Route("api/[controller]")]
        public IActionResult PostEmployee(Models.Employee employee)
        {
            _employeeInterface.AddEmployee(employee);

            return Created(HttpContext.Request.Scheme + "//" + HttpContext.Request.Host + HttpContext.Request.Path + "/" + employee.id, employee);
        }


        /**
       *  delete an employee
       */
        [HttpDelete]
        [Route("api/[controller]/{id}")]
        public IActionResult DeleteEmployee( Guid id)
        {
            var employee = _employeeInterface.GetEmployee(id);

            if (employee != null)
            {
                _employeeInterface.DeleteEmployee( id, employee); 
                return Ok(); 
            }

            return NotFound();
           
        }


        /**
       *  update employee
       */
        [HttpPut]
        [Route("api/[controller]/{id}")]
        public IActionResult UpdateEmployee(Guid id, Employee employee)
        { 
            var existingEmployee = _employeeInterface.GetEmployee(id);

            if (employee != null)
            {
                 _employeeInterface.UpdateEmployee(id, employee);

                return NoContent(); 
            }

            return NotFound(); 
        }


    }
}
