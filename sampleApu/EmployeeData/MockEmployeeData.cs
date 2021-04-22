using System;
using System.Collections.Generic;
using System.Linq;
using sampleApu.Models;

namespace sampleApu.EmployeeData
{
    public class MockEmployeeData : IEmployeeRespository
    {
        private List<Employee> employees = new List<Employee>()
        {
            new Employee()
            {
                id = Guid.NewGuid(),
                Name = "Ameks",
            },

             new Employee()
            {
                id = Guid.NewGuid(),
                Name = "Jepus",
            }

        };

        public Employee AddEmployee(Employee employee)
        {
           employee.id = Guid.NewGuid();

           employees.Add(employee);
            return employee; 
        }

        public void DeleteEmployee(Guid id, Employee employee)
        { 
            employees.Remove(employee); 
        }

        public Employee GetEmployee(Guid id)
        {
            return employees.SingleOrDefault( x => x.id == id );
        }

        public List<Employee> GetEmployees()
        {
            return employees;
        }

        public string UpdateEmployee(Guid id, Employee employee)
        {
            var existingEmployee = GetEmployee(employee.id);

            existingEmployee.Name = employee.Name;

            return ""; 
        }
    }
}
