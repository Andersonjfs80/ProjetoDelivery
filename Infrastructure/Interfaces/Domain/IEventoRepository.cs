using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Domain.Entidades;
using Infrastructure.Interfaces.Domain.Standard;

namespace Infrastructure.Interfaces.Domain
{
    public interface IEventoRepository : IDomainRepository<Evento>
    {
        Task<bool> CreateOrUpdate(Evento evento);

        Task<IEnumerable<Evento>> GetAllIncludingAsync(Expression<Func<Evento, bool>> filter = null, Func<IQueryable<Evento>, IOrderedQueryable<Evento>> orderBy = null, params string[] includeProperties);

        Task<Evento> GetByIdIncludingAsync(Expression<Func<Evento, bool>> filter, params string[] includeProperties);
    }
}
