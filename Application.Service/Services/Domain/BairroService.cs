using System.Threading.Tasks;
using Domain.Entidades;
using Application.Services.Domain;
using Application.Services.Standard;
using Infrastructure.Interfaces.Domain;
using System.Collections.Generic;
using System.Linq.Expressions;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Linq;

namespace Application.Services
{
    public class BairroService : Service<Bairro>, IBairroService
    {
        private readonly IBairroRepository _repository;

        public BairroService(IBairroRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public async Task<bool> CreateOrUpdate(Bairro bairro)
        {
            return await _repository.CreateOrUpdate(bairro);
        }

        public async Task<IEnumerable<Bairro>> GetAllIncludingAsync(Expression<Func<Bairro, bool>> filter = null, Func<IQueryable<Bairro>, IOrderedQueryable<Bairro>> orderBy = null)
        {
            return await _repository.GetAllIncludingAsync(filter, orderBy, includeProperties: new string[] { nameof(Bairro.Municipio) });
        }

        public async Task<Bairro> GetByIdIncludingAsync(Expression<Func<Bairro, bool>> filter)
        {
            return await _repository.GetByIdIncludingAsync(filter, includeProperties: new string[] { nameof(Bairro.Municipio) });
        }

        public async Task<Bairro> GetSelectOrCreate(Bairro bairro)
        {
            return await _repository.GetSelectOrCreate(bairro);
        }
    }
}
