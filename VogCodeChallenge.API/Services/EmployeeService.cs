using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VogCodeChallenge.API.DataAccess;
using VogCodeChallenge.API.Models;

namespace VogCodeChallenge.API.Services
{
    public class EmployeeService
    {
        private readonly IUnitOfWork _uow;

        public EmployeeService(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public IEnumerable<Employee> GetAll()
        {
            return _uow.Query<Employee>().ToList();
        }

        public IList<Employee> ListAll()
        {
            return _uow.Query<Employee>().ToList();
        }
    }
}
