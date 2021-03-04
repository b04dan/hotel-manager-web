using System;
using System.Linq;
using HotelManager.DAL.Interfaces;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace HotelManager.DAL.EF
{
    public class EFRepository<TEntity> : IRepository<TEntity> where TEntity : class, IEntity
    {
        protected readonly HotelDbContext _context;
        private readonly DbSet<TEntity> _dbSet;

        public EFRepository(HotelDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<TEntity>();
        }

        public IEnumerable<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null,
            params Expression<Func<TEntity, object>>[] includeProperties)
        {
            IQueryable<TEntity> query = _dbSet;

            if (filter != null)
            {
                query = query.Where(filter);
            }

            foreach (var includeProperty in includeProperties)
            {
                query = query.Include(includeProperty);
            }


            return query.AsNoTracking().AsEnumerable();
        }

        public TEntity GetById(int id)
        {
            return _dbSet.SingleOrDefault(s => s.Id == id);
        }

        public void Add(TEntity entity)
        {
            if (entity == null) throw new ArgumentNullException();

            _dbSet.Add(entity);
        }

        public void Update(TEntity entity)
        {
            if (entity == null) throw new ArgumentNullException();
            _context.Entry(entity).State = EntityState.Modified;
        }
        public void Remove(int id)
        {
            TEntity entity = _dbSet.SingleOrDefault(s => s.Id == id);
            _dbSet.Remove(entity);
        }
    }
}
