using System;
using Microsoft.EntityFrameworkCore;
namespace sampleApu.Models
{
    public class EmployeeContext : DbContext
    {

        // Dbset database properties  
        public DbSet<Employee> Employees { get; set; }


        // create a contructure
        public EmployeeContext(DbContextOptions<EmployeeContext> options) : base(options)
        {
        }

      
    }
}
