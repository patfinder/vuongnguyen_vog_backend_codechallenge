using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VogCodeChallenge.API.Models
{
    public class Department
    {
        public string Id { get; set; }
     
        public string Name { get; set; }

        public string Address { get; set; }

        public ICollection<Employee> Employees { get; set; }
    }
}
