using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VogCodeChallenge.API.Models
{
    public class Employee
    {
        public string Id { get; set; }

        public string DepartmentId { get; set; }
        
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string JobTitle { get; set; }

        public string Address { get; set; }

        public Department Department { get; set; }
    }
}
