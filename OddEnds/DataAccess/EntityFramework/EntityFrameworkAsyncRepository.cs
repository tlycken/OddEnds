using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OddEnds.DataAccess.Abstractions;

namespace OddEnds.DataAccess.EntityFramework
{
    public class EntityFrameworkAsyncRepository<TEntity, TContext>
        : IAsyncRepository<TEntity>
        where TEntity : class, IEntity
        where TContext : DbContext
    {
        private TContext context;

        public EntityFrameworkAsyncRepository(TContext ctx)
        {
            context = ctx;
        }

        public async Task<TEntity> GetById(int id)
        {
            return await Task.Run(() => context.Set<TEntity>().SingleOrDefault(t => t.ID == id));
        }

        public async Task<IEnumerable<TEntity>> GetAll()
        {
            return await Task.Run(() => context.Set<TEntity>().ToList());
        }

        public async Task Add(TEntity newEntity)
        {
            await Task.Run(() => context.Set<TEntity>().Add(newEntity));
        }

        public async Task DeleteByID(int id)
        {
            var entityToRemove = await Task.Run(() => this.GetById(id));
            await Task.Run(() => context.Set<TEntity>().Remove(entityToRemove));
        }
    }
}
