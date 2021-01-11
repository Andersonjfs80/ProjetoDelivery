using Domain.Entidades;
using Application.Interfaces.Standard;
using Infrastructure.Interfaces.Standard;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq.Expressions;
using System;
using System.Linq;

namespace Application.Services.Standard
{
    public class Service<TEntity> : IService<TEntity> where TEntity : class
    {
        protected readonly IRepository<TEntity> repository;

        //protected ModelStateDictionary modelState;

        public Service(/*ModelStateDictionary modelState,*/ IRepository<TEntity> repository)
        {
            this.repository = repository;
            //this.modelState = modelState;
        }

        //public ServiceBase() => _context = Activator.CreateInstance<BancoDadosCoreContext>();
        //public ServiceBase(BancoDadosCoreContext context) => _context = context;

        public virtual async Task<bool> AddAsync(TEntity obj)
        {
            //if (!ValidateModelState(obj))
            //{ return false; }

            repository.AddAsync(obj);
            return await SaveAsync();
        }

        public virtual async Task<bool> Update(TEntity obj)
        {
            //if (!ValidateModelState(obj))
            //{ return false; }

            repository.Update(obj);
            return await SaveAsync();
        }

        public virtual async Task<bool> Delete(TEntity obj)
        {
            repository.Delete(obj);
            return await SaveAsync();
        }

        public virtual async Task<bool> SaveAsync() => await repository.SaveAsync() > 0 ? true : false;

        public virtual async Task<IEnumerable<TEntity>> GetAllAsync() => await repository.GetAllAsync();               

        public virtual async Task<TEntity> GetByIdAsync(Expression<Func<TEntity, bool>> filter) => await repository.GetByIdAsync(filter);
        
        //public virtual bool ValidateModelState(T obj)
        //{
        //    //return modelState.IsValid;
        //}
    }
}
