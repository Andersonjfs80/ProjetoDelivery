using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Infrastructure.DBConfiguration.EFCore;
using Infrastructure.Interfaces.Domain;
using Infrastructure.Repositories.Domain.Standard;

namespace Infrastructure.Repositories.Domain
{
    public class BairroRepository : DomainRepository<Bairro>, IBairroRepository
    {
        public BairroRepository(ApplicationContext context) : base(context) { }

        public async Task<bool> CreateOrUpdate(Bairro bairro)
        {
            if (bairro.BairroId > 0)
            {
                Update(bairro);
            }
            else
            {
                AddAsync(bairro);
            }

            return await SaveAsync() > 0;
        }
                                               
        public async Task<IEnumerable<Bairro>> GetAllIncludingAsync(Expression<Func<Bairro, bool>> filter = null, Func<IQueryable<Bairro>, IOrderedQueryable<Bairro>> orderBy = null, params string[] includeProperties)
        {
            IQueryable<Bairro> query = dbSet;

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

        public async Task<Bairro> GetByIdIncludingAsync(Expression<Func<Bairro, bool>> filter, params string[] includeProperties)
        {
            IQueryable<Bairro> query = dbSet;

            if (includeProperties != null)
            {
                query = GenerateIncludeProperties(query, includeProperties);
            }

            return await query.SingleOrDefaultAsync(filter);
        }

        public async Task<Bairro> GetSelectOrCreate(Bairro bairro)
        {
            var newBairro = await GetByIdAsync(b => (b.Nome.ToUpper() == bairro.Nome.ToUpper()) && (b.MunicipioId == bairro.MunicipioId));
            if (newBairro == null)
            {
                newBairro = new Bairro() { Nome = bairro.Nome, MunicipioId = bairro.MunicipioId, Municipio = bairro.Municipio };
                if (CreateOrUpdate(newBairro).Result == true)
                {
                    return newBairro;
                }

                return null;
            }

            return newBairro;
        }
    }
}
