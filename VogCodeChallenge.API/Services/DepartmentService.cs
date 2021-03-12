using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VogCodeChallenge.API.DataAccess;
using VogCodeChallenge.API.Models;

namespace VogCodeChallenge.API.Services
{
    public class DepartmentService
    {
        private readonly IUnitOfWork _uow;

        public DepartmentService(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public IEnumerable<Department> GetAll()
        {
            return _uow.Query<Department>().ToList();
        }

        public Department Find(string id)
        {
            return _uow.Query<Department>().First();
        }
    }
}
