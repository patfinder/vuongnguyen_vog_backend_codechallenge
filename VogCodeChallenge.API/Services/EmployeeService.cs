using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VogCodeChallenge.API.Models;

namespace VogCodeChallenge.API.Services
{
    public class EmployeeService
    {
        private static List<Employee> _employees = new List<Employee> {
            new Employee{ Id = "Emp1", FirstName = "Abigail", LastName = "Adam", DepartmentId = "RnD", JobTitle = "Developer", Address = "1104  Breezewood Court"},
            new Employee{ Id = "Emp2", FirstName = "Alexandra", LastName = "Adrian", DepartmentId = "RnD", JobTitle = "Developer", Address = "1104  Breezewood Court"},
            new Employee{ Id = "Emp3", FirstName = "Alison", LastName = "Alan", DepartmentId = "RnD", JobTitle = "Developer", Address = "1104  Breezewood Court"},
            new Employee{ Id = "Emp4", FirstName = "Amanda", LastName = "Alexander", DepartmentId = "RnD", JobTitle = "Developer", Address = "1104  Breezewood Court"},
        };

        public EmployeeService()
        {
        }

        public IEnumerable<Employee> GetAll()
        {
            return _employees;
        }

        public IList<Employee> ListAll()
        {
            return _employees;
        }
    }
}
