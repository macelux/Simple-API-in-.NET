using System;
using System.Collections.Generic;
using sampleApu.Models;

namespace sampleApu.EmployeeData
{
    public interface IEmployeeRespository
    {
        List<Employee> GetEmployees();

        Employee GetEmployee(Guid id);

        Employee AddEmployee(Employee employee);

        void DeleteEmployee(Guid id, Employee employee);

        string UpdateEmployee(Guid id , Employee employee); 

    }
}
