using Domain.Entidades;
using Infrastructure.Interfaces.Domain.Standard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Interfaces.Domain
{
    public interface IEventoOrderRepository : IDomainRepository<EventoOrder>    
    {
        Task<bool> CreateOrUpdate(EventoOrder eventoOrder);

        Task<IEnumerable<EventoOrder>> GetAllIncludingAsync(Expression<Func<EventoOrder, bool>> filter = null, Func<IQueryable<EventoOrder>, IOrderedQueryable<EventoOrder>> orderBy = null, params string[] includeProperties);

        Task<EventoOrder> GetByIdIncludingAsync(Expression<Func<EventoOrder, bool>> filter, params string[] includeProperties);
    }
}
