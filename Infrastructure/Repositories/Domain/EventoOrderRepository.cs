using Domain.Entidades;
using Infrastructure.DBConfiguration.EFCore;
using Infrastructure.Interfaces.Domain;
using Infrastructure.Repositories.Domain.Standard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories.Domain
{
    public class EventoOrderRepository : DomainRepository<EventoOrder>, IEventoOrderRepository
    {
        public EventoOrderRepository(ApplicationContext context) : base(context) { }

        public async Task<bool> CreateOrUpdate(EventoOrder eventoOrder)
        {
            if (eventoOrder.EventoOrderId > 0)
            {
                Update(eventoOrder);
            }
            else
            {
                AddAsync(eventoOrder);
            }

            return await SaveAsync() > 0;
        }

        public async Task<IEnumerable<EventoOrder>> GetAllIncludingAsync(Expression<Func<EventoOrder, bool>> filter = null, Func<IQueryable<EventoOrder>, IOrderedQueryable<EventoOrder>> orderBy = null, params string[] includeProperties)
        {
            IQueryable<EventoOrder> query = dbSet;

            if (includeProperties != null)
            {
                query = GenerateIncludeProperties(query, includeProperties);
            }

            if (filter != null)
            {
                query = query.Where(filter);
            }

            if (orderBy != null)
            {
                query = orderBy(query);
            }

            return await query.ToListAsync();
        }

        public async Task<EventoOrder> GetByIdIncludingAsync(Expression<Func<EventoOrder, bool>> filter, params string[] includeProperties)
        {
            IQueryable<EventoOrder> query = dbSet;

            if (includeProperties != null)
            {
                query = GenerateIncludeProperties(query, includeProperties);
            }

            return await query.SingleOrDefaultAsync(filter);
        }
    }
}
