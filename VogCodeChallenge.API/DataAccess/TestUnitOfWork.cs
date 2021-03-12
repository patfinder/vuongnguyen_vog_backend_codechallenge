using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using VogCodeChallenge.API.Models;

namespace VogCodeChallenge.API.DataAccess
{
    public class TestUnitOfWork : IUnitOfWork
    {
        private static List<Employee> _employees = new List<Employee> {
            new Employee{ Id = "Emp1", FirstName = "Abigail", LastName = "Adam", DepartmentId = "RnD", JobTitle = "Developer", Address = "1104  Breezewood Court"},
            new Employee{ Id = "Emp2", FirstName = "Alexandra", LastName = "Adrian", DepartmentId = "RnD", JobTitle = "Developer", Address = "1104  Breezewood Court"},
            new Employee{ Id = "Emp3", FirstName = "Alison", LastName = "Alan", DepartmentId = "RnD", JobTitle = "Developer", Address = "1104  Breezewood Court"},
            new Employee{ Id = "Emp4", FirstName = "Amanda", LastName = "Alexander", DepartmentId = "RnD", JobTitle = "Developer", Address = "1104  Breezewood Court"},
        };

        private static List<Department> _departments = new List<Department> {
            new Department{ Id = "RnD", Name = "RnD Department", Address = "Floor 5"},
            new Department{ Id = "HR", Name = "HR Department", Address = "Floor 2"},
        };

        private DbContext _context;

        public TestUnitOfWork(DbContext context)
        {
            _context = context;
        }

        public DbContext Context => _context;

        public ITransaction BeginTransaction(IsolationLevel isolationLevel = IsolationLevel.Snapshot)
        {
            return new DbTransaction(/*_context.Database.BeginTransaction(isolationLevel)*/);
        }

        public void Add<T>(T obj)
            where T : class
        {
            //var set = _context.Set<T>();
            //set.Add(obj);
        }

        public void Update<T>(T obj)
            where T : class
        {
            //var set = _context.Set<T>();
            //set.Attach(obj);
            //_context.Entry(obj).State = EntityState.Modified;
        }

        void IUnitOfWork.Remove<T>(T obj)
        {
            //var set = _context.Set<T>();
            //set.Remove(obj);
        }

        public IQueryable<T> Query<T>()
            where T : class
        {
            IList<T> result = new List<T>();

            if(typeof(Employee).IsAssignableFrom(typeof(T)))
            {
                _employees.ForEach(e => result.Add(e as T));
            }

            else if (typeof(Department).IsAssignableFrom(typeof(T)))
            {
                _departments.ForEach(e => result.Add(e as T));
            }

            return result.AsQueryable();
        }

        public void Commit()
        {
            //_context.SaveChanges();
        }

        #pragma warning disable 1998
        public async Task CommitAsync()
        {
            //await _context.SaveChangesAsync();
        }
        #pragma warning restore 1998

        public void Attach<T>(T newUser) where T : class
        {
            //var set = _context.Set<T>();
            //set.Attach(newUser);
        }

        public void Dispose()
        {
            _context = null;
        }
    }
}