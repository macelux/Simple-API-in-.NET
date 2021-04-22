using System;
using System.Collections.Generic;
using System.Linq;
using sampleApu.Models;



namespace sampleApu.EmployeeData
{
    public class EmployeeRepository : IEmployeeRespository
    {

        private EmployeeContext _employeeContext;

        public EmployeeRepository(EmployeeContext employeeContext)
        {
            _employeeContext = employeeContext;
        }

        /*
         * Add Employee
         * @return Employee
         */
        public Employee AddEmployee(Employee employee)
        {
            _employeeContext.Add(employee);
            _employeeContext.SaveChanges();
            return employee;
        }

        /*
         * Delete Employee
         * @return void
         */
        public void DeleteEmployee(Guid id, Employee employee)
        {
            var result = _employeeContext.Employees.Find(id);

            if (result != null)
                _employeeContext.Remove(result);
                _employeeContext.SaveChanges();
        }

        /*
         * Get Employee
         * @return Employee
         */
        public Employee GetEmployee(Guid id)
        {
            var employee = _employeeContext.Employees.Find(id);
            return employee;
        }

        /*
         * Get Employees
         * @return List
         */
        public List<Employee> GetEmployees()
        {
            return _employeeContext.Employees.ToList();
        }

        /*
         * Update Employee
         * @return String
         */
        public string UpdateEmployee(Guid id, Employee employee)
        {
            var result = _employeeContext.Employees.Find(id);

            if (result != null)
            {
                result.Name = employee.Name;
                _employeeContext.SaveChanges();
                return "true";
            }

            return "false";
        }


    }
    
} 
