using System;

namespace VogCodeChallenge.API.DataAccess
{
    public interface ITransaction : IDisposable
    {
        void Commit();
        void Rollback();
    }
}