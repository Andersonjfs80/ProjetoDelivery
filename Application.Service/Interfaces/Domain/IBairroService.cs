using System.Threading.Tasks;
using Domain.Entidades;
using Application.Interfaces.Standard;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq.Expressions;
using System;
using System.Linq;

namespace Application.Services.Domain
{
    public interface IBairroService : IService<Bairro>
    {
        Task<bool> CreateOrUpdate(Bairro bairro);

        Task<IEnumerable<Bairro>> GetAllIncludingAsync(Expression<Func<Bairro, bool>> filter = null, Func<IQueryable<Bairro>, IOrderedQueryable<Bairro>> orderBy = null);

        Task<Bairro> GetByIdIncludingAsync(Expression<Func<Bairro, bool>> filter);

        Task<Bairro> GetSelectOrCreate(Bairro bairro);
    }    
}
