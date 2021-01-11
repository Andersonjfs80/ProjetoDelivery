using Infrastructure.Interfaces.Domain.Standard;
using Infrastructure.Repositories.Standard.EFCore;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories.Domain.Standard
{
    public class DomainRepository<TEntity> : Repository<TEntity>, 
                                             IDomainRepository<TEntity> where TEntity : class
    {
        protected DomainRepository(DbContext dbContext) : base(dbContext)
        {
        }

        protected DomainRepository() : base()
        {
        }
    }
}
