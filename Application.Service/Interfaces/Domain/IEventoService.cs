using System.Threading.Tasks;
using Application.Interfaces.Standard;
using System.Collections.Generic;
using System.Linq.Expressions;
using System;
using System.Linq;
using Domain.Entidades;

namespace Application.Services.Domain
{
    public interface IEventoService : IService<Evento>
    {
        Task<bool> CreateOrUpdate(Evento evento);

        Task<IEnumerable<Evento>> GetAllIncludingAsync(Expression<Func<Evento, bool>> filter = null, Func<IQueryable<Evento>, IOrderedQueryable<Evento>> orderBy = null);

        Task<Evento> GetByIdIncludingAsync(Expression<Func<Evento, bool>> filter);
    }    
}
