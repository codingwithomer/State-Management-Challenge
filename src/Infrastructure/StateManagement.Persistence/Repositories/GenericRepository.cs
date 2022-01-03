using Microsoft.EntityFrameworkCore;
using StateManagement.Application.Interfaces.Repositories;
using StateManagement.Domain.Common;
using StateManagement.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace StateManagement.Persistence.Repositories
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : BaseEntity, new()
    {
        private readonly EFDbContext _context;

        public GenericRepository(EFDbContext context)
        {
            _context = context;
        }

        public async Task<TEntity> AddAsync(TEntity entity)
        {
            await _context.Set<TEntity>().AddAsync(entity);

            return entity;
        }

        public async Task<TEntity> GetAsync(Guid id)
        {
            return await _context.Set<TEntity>().FindAsync(id);
        }

        public async Task<IEnumerable<TEntity>> GetAsync(Expression<Func<TEntity, bool>> predicate = null)
        {
            return await _context.Set<TEntity>().Where(predicate).ToListAsync();
        }

        public async Task<IEnumerable<TEntity>> GetAsync()
        {
            return await _context.Set<TEntity>().ToListAsync();
        }

        public void Remove(Guid id)
        {
            var deletedEntity = _context.Set<TEntity>().Find(id);
            deletedEntity.IsActive = false;
            deletedEntity.ModifiedDate = DateTime.UtcNow;

            _context.Set<TEntity>().Update(deletedEntity);
        }

        public Task<TEntity> UpdateAsync(TEntity entity)
        {
            entity.ModifiedDate = DateTime.UtcNow;

            _context.Set<TEntity>().Update(entity);

            return Task.FromResult(entity);
        }
    }
}
