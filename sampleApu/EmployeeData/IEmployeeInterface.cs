using System;
using System.Collections.Generic;
using sampleApu.Models;

namespace sampleApu.EmployeeData
{
    public interface IEmployeeInterface
    {
        List<Employee> GetEmployees();

        Employee GetEmployee(Guid id);

        Employee AddEmployee(Employee employee);

        void DeleteEmployee(Employee employee);

        string UpdateEmployee(Guid id , Employee employee); 

    }
}
