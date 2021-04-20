using System;
using System.Collections.Generic;
using System.Linq;
using sampleApu.Models;

namespace sampleApu.EmployeeData
{
    public class SqlEmployeeData : IEmployeeInterface
    {

        private EmployeeContext _employeeContext;

        public SqlEmployeeData(EmployeeContext employeeContext)
        {
            _employeeContext = employeeContext;
        }

        public Employee AddEmployee(Employee employee)
        {  
            _employeeContext.Add(employee);
            _employeeContext.SaveChanges();
            return employee;
        }

        public void DeleteEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }

        public Employee GetEmployee(Guid id)
        {
            var employee = _employeeContext.Employees.Find(id);
            return employee;
        }

        public List<Employee> GetEmployees()
        {
            return _employeeContext.Employees.ToList();
        }

        public string UpdateEmployee(Guid id , Employee employee)
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
