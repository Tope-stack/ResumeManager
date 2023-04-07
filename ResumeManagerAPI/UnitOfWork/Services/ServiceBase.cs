using ResumeManagerAPI.Data;
using ResumeManagerAPI.UnitOfWork.Interfaces;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace ResumeManagerAPI.UnitOfWork.Services
{
    public class ServiceBase<T> : IServiceBase<T> where T : class
    {
        protected AppDbContext _context;

        public ServiceBase(AppDbContext context)
        {
            _context = context;
        }

        public async Task CreateAsync(T entity) => await Task.Run(() => _context.Set<T>().Add(entity));


        public async Task<IQueryable<T>> FindAllAsync(bool trackChanges) =>
             !trackChanges ? await Task.Run(() => _context.Set<T>()
                 .AsNoTracking()) : await Task.Run(() => _context.Set<T>());


        public async Task<IQueryable<T>> FindByConditionAsync(Expression<Func<T, bool>> expression, bool trackChanges)
            => !trackChanges ? await Task.Run(() => _context.Set<T>().Where(expression).AsNoTracking())
            : await Task.Run(() => _context.Set<T>().Where(expression));
        

        public async Task RemoveAsync(T entity) => await Task.Run(() => _context.Set<T>().Remove(entity));


        public async Task UpdateAsync(T entity) => await Task.Run(() => _context.Set<T>().Update(entity));
        
    }
}
