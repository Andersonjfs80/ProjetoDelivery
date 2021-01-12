using Application.Services.Domain;
using Application.Services.Standard;
using Domain.Entidades;
using Infrastructure.Interfaces.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Application.Services
{
    public class EventoService : Service<Evento>, IEventoService
    {
        private readonly IEventoRepository _repository;

        public EventoService(IEventoRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public async Task<bool> CreateOrUpdate(Evento evento)
        {
            return await _repository.CreateOrUpdate(evento);
        }

        public async Task<IEnumerable<Evento>> GetAllIncludingAsync(Expression<Func<Evento, bool>> filter = null, Func<IQueryable<Evento>, IOrderedQueryable<Evento>> orderBy = null)
        {
            return await _repository.GetAllIncludingAsync(filter, orderBy, includeProperties: new string[] { nameof(Evento.EventoPolling) });
        }

        public async Task<Evento> GetByIdIncludingAsync(Expression<Func<Evento, bool>> filter)
        {
            return await _repository.GetByIdIncludingAsync(filter, includeProperties: new string[] { nameof(Evento.EventoPolling) });
        }
    }
}
