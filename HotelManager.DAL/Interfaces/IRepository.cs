using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Linq.Expressions;

namespace HotelManager.DAL.Interfaces
{
    public interface IRepository<TEntity> where TEntity : class, IEntity
    {
        void Add(TEntity item);
        IEnumerable<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null,
            params Expression<Func<TEntity, object>>[] includeProperties);
        TEntity GetById(int Id);
        void Update(TEntity item);
        void Remove(int id);
    }
}
