using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VogCodeChallenge.API.Models;

namespace VogCodeChallenge.API.Services
{
    public class DepartmentService
    {
        private static List<Department> _departments = new List<Department> {
            new Department{ Id = "RnD", Name = "RnD Department", Address = "Floor 5"},
            new Department{ Id = "HR", Name = "HR Department", Address = "Floor 2"},
        };

        public DepartmentService()
        {
        }

        public IEnumerable<Department> GetAll()
        {
            return _departments;
        }

        public Department Find(string id)
        {
            return _departments.FirstOrDefault(d => d.Id == id);
        }
    }
}
