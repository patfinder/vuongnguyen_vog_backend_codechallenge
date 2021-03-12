using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VogCodeChallenge.API.DataAccess
{
    public class DbContext
    {
        public DbSet<T> Set<T>()
        {
            return new DbSet<T>();
        }

        public void Entry()
        {
        }
    }
}
