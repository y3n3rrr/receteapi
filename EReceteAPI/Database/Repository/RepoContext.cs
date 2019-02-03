using Data.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EReceteAPI.Database.Repository
{
    public class RepoContext : UnitOfWork
    {
        protected static object lockObj = new object();
        protected RepoContext _instance = null;

        public static RepoContext Current
        {
            get
            {
                //if (_instance == null)
                //{
                //    lock (lockObj)
                //    {
                //        if (_instance == null)
                //            _instance = new RepoContext();
                //    }
                //}
                //return _instance;
                return new RepoContext();
            }
        }

        private UserRepository _userRepository;

        public UserRepository UserRepository
        {
            get
            {
                if (this._userRepository == null)
                {
                    this._userRepository = new UserRepository(context);
                }
                return _userRepository;
            }
        }
    }

    public class UnitOfWork : IDisposable
    {
        protected EReceteDBContext context = new EReceteDBContext();
        public int Save()
        {
            return context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
