using Infrastructure.DBConfiguration.EFCore;
using Infrastructure.Interfaces.Domain;
using Infrastructure.Repositories.Domain.Standard;

namespace Infrastructure.Repositories.Domain
{
    public class EventoRepository : DomainRepository<Evento>, IEventoRepository
    {
        public EventoRepository(ApplicationContext context) : base(context) { }

        public async Task<bool> CreateOrUpdate(Evento evento)
        {
            if (Evento.EventoId > 0)
            {
                Update(evento);
            }
            else
            {
                AddAsync(evento);
            }

            return await SaveAsync() > 0;
        }
                                               
        public async Task<IEnumerable<Evento>> GetAllIncludingAsync(Expression<Func<Evento, bool>> filter = null, Func<IQueryable<Evento>, IOrderedQueryable<Evento>> orderBy = null, params string[] includeProperties)
        {
            IQueryable<Evento> query = dbSet;

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

        public async Task<Evento> GetByIdIncludingAsync(Expression<Func<Evento, bool>> filter, params string[] includeProperties)
        {
            IQueryable<Evento> query = dbSet;

            if (includeProperties != null)
            {
                query = GenerateIncludeProperties(query, includeProperties);
            }

            return await query.SingleOrDefaultAsync(filter);
        }
    }
}
