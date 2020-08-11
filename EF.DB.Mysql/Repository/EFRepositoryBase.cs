using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EF.DB.Mysql.Repository
{
    public class EFRepositoryBase<T> : IDisposable where T : class
    {
        private bool disposed = false;
        protected readonly DataContext _dbContext;
        public EFRepositoryBase()
        {
            _dbContext = new DataContext();
        }
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _dbContext.Dispose();
                }
            }
            this.disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public async Task<int> AddAsync(T entity)
        {
            _dbContext.Set<T>().Add(entity);
            return await _dbContext.SaveChangesAsync();
        }

        public async Task<int> UpdateAsync(T entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
            return await _dbContext.SaveChangesAsync();
        }

        public async Task<List<T>> GetAsync()
        {
            return await _dbContext.Set<T>().ToListAsync<T>();
        }
        public async Task<int> DelAsync(T entity)
        {
            _dbContext.Remove(entity);
            return await _dbContext.SaveChangesAsync();
        }
    }
}
