using StateManagement.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace StateManagement.Application.Interfaces.Repositories
{
    public interface IGenericRepository<TEntity> where TEntity : BaseEntity,new()
    {
        Task<TEntity> AddAsync(TEntity entity);
        Task<TEntity> GetAsync(Guid id);
        void Remove(Guid id);
        Task<IEnumerable<TEntity>> GetAsync(Expression<Func<TEntity, bool>> predicate = null);
        Task<TEntity> UpdateAsync(TEntity entity);
    }
}
