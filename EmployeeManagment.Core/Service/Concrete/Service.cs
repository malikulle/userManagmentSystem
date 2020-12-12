using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using EmployeeManagment.Core.Data.Abstract;
using EmployeeManagment.Core.Data.Concrete;
using EmployeeManagment.Core.Service.Abstract;
using EmployeeManagment.Data.Context;
using EmployeeManagment.Entities.Trackable;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagment.Core.Service.Concrete
{
    public class Service<T> : IService<T>
        where T : BaseEntity, IEntity, new()
    {
        private readonly IRepository<T> _repository;
        public Service(IRepository<T> repository)
        {
            _repository = repository;
        }

        public virtual T GetById(int Id)
            => _repository.GetById(Id);

        public virtual async Task<T> GetAsync(Expression<Func<T, bool>> predicate,
            params Expression<Func<T, object>>[] includeProperties)
            => await _repository.GetAsync(predicate, includeProperties);

        public virtual async Task<List<T>> GetAllAsync(Expression<Func<T, bool>> predicate = null,
            params Expression<Func<T, object>>[] includeProperties)
            => await _repository.GetAllAsync(predicate, includeProperties);

        public virtual async Task<T> InsertAsync(T entity)
            => await _repository.InsertAsync(entity);

        public virtual async Task<T> AttachAsync(T entity)
            => await _repository.AttachAsync(entity);

        public virtual async Task<T> UpdateAsync(T entity)
            => await _repository.UpdateAsync(entity);

        public virtual async Task DeleteAsync(T entity)
            => await _repository.DeleteAsync(entity);

        public virtual async Task<bool> AnyAsync(Expression<Func<T, bool>> predicate)
            => await _repository.AnyAsync(predicate);

        public virtual async Task<int> CountAsync(Expression<Func<T, bool>> predicate)
            => await _repository.CountAsync(predicate);

        public virtual IQueryable<T> Queryable()
            => _repository.Queryable();
    }
}
