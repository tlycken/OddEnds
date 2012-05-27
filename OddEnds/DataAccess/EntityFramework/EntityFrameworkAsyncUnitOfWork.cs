using System;
using System.Data.Entity;
using System.Threading.Tasks;
using OddEnds.DataAccess.Abstractions;

namespace OddEnds.DataAccess.EntityFramework
{
    public abstract class EntityFrameworkAsyncUnitOfWorkBase<TContext> 
        : IDisposable, IAsyncUnitOfWork
        where TContext : DbContext
    {
        private readonly TContext _context;

        protected EntityFrameworkAsyncUnitOfWorkBase(TContext context)
        {
            _context = context;
        }
        
        private bool _disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if(!_disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            _disposed = true;
        }
        
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public async Task Save()
        {
            await Task.Run(() => _context.SaveChanges());
        }
    }
}
