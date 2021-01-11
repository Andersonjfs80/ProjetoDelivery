using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Interfaces.Domain
{
    public interface IEventoPolling : IDomainRepository<EventoPolling>
    {
        Task<bool> CreateOrUpdate(EventoPolling eventoPolling);

        Task<IEnumerable<EventoPolling>> GetAllIncludingAsync(Expression<Func<EventoPolling, bool>> filter = null, Func<IQueryable<EventoPolling>, IOrderedQueryable<EventoPolling>> orderBy = null, params string[] includeProperties);

        Task<EventoPolling> GetByIdIncludingAsync(Expression<Func<EventoPolling, bool>> filter, params string[] includeProperties);
    }
}
