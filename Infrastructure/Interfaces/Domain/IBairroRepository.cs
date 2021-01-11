using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Domain.Entidades;
using Infrastructure.Interfaces.Domain.Standard;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Infrastructure.Interfaces.Domain
{
    public interface IBairroRepository : IDomainRepository<Bairro>
    {
        Task<bool> CreateOrUpdate(Bairro bairro);

        Task<IEnumerable<Bairro>> GetAllIncludingAsync(Expression<Func<Bairro, bool>> filter = null, Func<IQueryable<Bairro>, IOrderedQueryable<Bairro>> orderBy = null, params string[] includeProperties);

        Task<Bairro> GetByIdIncludingAsync(Expression<Func<Bairro, bool>> filter, params string[] includeProperties);

        Task<Bairro> GetSelectOrCreate(Bairro bairro);
    }
}
