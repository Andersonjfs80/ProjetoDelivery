﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Interfaces.Standard;
using System.Collections;

namespace Infrastructure.Repositories.Standard.EFCore
{
    public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly DbContext dbContext;

        protected readonly DbSet<TEntity> dbSet;

        public Repository()
        {
            this.dbContext = Activator.CreateInstance<DbContext>();
            this.dbSet = this.dbContext.Set<TEntity>();
        }

        public Repository(DbContext dbContext)
        {
            this.dbContext = dbContext;
            this.dbSet = this.dbContext.Set<TEntity>();
        }

        public async void AddAsync(TEntity entity)
        {
            dbSet.Attach(entity).State = EntityState.Added;
            await dbSet.AddAsync(entity);
        }

        public void Update(TEntity entity)
        {
            dbSet.Attach(entity).State = EntityState.Modified;
            dbSet.Update(entity);
        }

        public void Delete(TEntity entity)
        {
            dbSet.Attach(entity).State = EntityState.Deleted;
            dbSet.Remove(entity);
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await dbSet.ToListAsync();
        }

        public async Task<TEntity> GetByIdAsync(Expression<Func<TEntity, bool>> filter)
        {
            return await dbSet.Where(filter).SingleOrDefaultAsync();
        }

        public async Task<int> SaveAsync()
        {
            return await dbContext.SaveChangesAsync();
        }

        protected IQueryable<TEntity> GenerateIncludeProperties(IQueryable<TEntity> query, params string[] includeProperties)
        {
            foreach (string includeProperty in includeProperties)
                query = query.Include(includeProperty);

            return query;
        }

        public void Dispose()
        {
            dbContext.Dispose();
            GC.SuppressFinalize(this);
        }

    }
}
