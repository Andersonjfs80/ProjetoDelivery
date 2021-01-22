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
    public class EventoPollingRepository : DomainRepository<EventoPolling>, IEventoPollingRepository
    {
        public EventoPollingRepository(ApplicationContext context) : base(context) { }

        public async Task<bool> CreateOrUpdate(EventoPolling eventoPolling)
        {
            if (eventoPolling.EventoPollingId > 0)
            {
                Update(eventoPolling);
            }
            else
            {
                AddAsync(eventoPolling);
            }

            return await SaveAsync() > 0;
        }

        public async Task<IEnumerable<EventoPolling>> GetAllIncludingAsync(Expression<Func<EventoPolling, bool>> filter, Func<IQueryable<EventoPolling>, IOrderedQueryable<EventoPolling>> orderBy, params string[] includeProperties)
        {
            IQueryable<EventoPolling> query = dbSet;

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

        public async Task<EventoPolling> GetByIdIncludingAsync(Expression<Func<EventoPolling, bool>> filter, params string[] includeProperties)
        {
            IQueryable<EventoPolling> query = dbSet;

            if (includeProperties != null)
            {
                query = GenerateIncludeProperties(query, includeProperties);
            }

            return await query.SingleOrDefaultAsync(filter);
        }
    }
}
