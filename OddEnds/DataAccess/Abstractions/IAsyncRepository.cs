using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEnds.DataAccess.Abstractions
{
    public interface IAsyncRepository<TEntity>
        : IAsyncRepository
        where TEntity : class, IEntity
    {
        Task<TEntity> GetById(int id);
        Task<IEnumerable<TEntity>> GetAll();

        Task Add(TEntity newEntity);
        Task DeleteByID(int id);
    }

    public interface IAsyncRepository
    {
    }
}
