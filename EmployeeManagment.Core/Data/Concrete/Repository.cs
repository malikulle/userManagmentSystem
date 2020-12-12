using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using EmployeeManagment.Core.Data.Abstract;
using EmployeeManagment.Data.Context;
using EmployeeManagment.Entities.Trackable;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagment.Core.Data.Concrete
{
    public class Repository<T> : IRepository<T>
        where T : BaseEntity, IEntity, new()
    {
        protected readonly DbContext _context;

        public Repository(EmployeeManagmentContext context)
        {
            _context = context;
        }

        public T GetById(int Id)
            => _context.Set<T>().Find(Id);

        public async Task<T> GetAsync(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> query = _context.Set<T>();

            if (includeProperties != null && includeProperties.Any())
            {
                foreach (var includeProp in includeProperties)
                {
                    query = query.Include(includeProp);
                }
            }
            return await query.SingleOrDefaultAsync(predicate);

        }

        public async Task<List<T>> GetAllAsync(Expression<Func<T, bool>> predicate = null, params Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> query = _context.Set<T>();

            if (predicate != null)
            {
                query = query.Where(predicate);
            }

            if (includeProperties != null && includeProperties.Any())
            {
                foreach (var includeProp in includeProperties)
                {
                    query = query.Include(includeProp);
                }
            }

            return await query.ToListAsync();
        }

        public async Task<T> InsertAsync(T entity)
        {
            _context.Entry(entity).State = EntityState.Added;
            return entity;
        }

        public async Task<T> AttachAsync(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
            return entity;
        }

        public async Task<T> UpdateAsync(T entity)
        {
            entity.ModifiedDate = DateTime.Now;
            _context.Entry(entity).State = EntityState.Modified;
            return entity;
        }


        public async Task DeleteAsync(T entity)
        {
            _context.Set<T>().Remove(entity);
        }

        public async Task<bool> AnyAsync(Expression<Func<T, bool>> predicate)
            => await _context.Set<T>().AnyAsync(predicate);


        public async Task<int> CountAsync(Expression<Func<T, bool>> predicate)
        => await _context.Set<T>().CountAsync(predicate);

        public IQueryable<T> Queryable()
            => _context.Set<T>().AsQueryable();
    }
}
