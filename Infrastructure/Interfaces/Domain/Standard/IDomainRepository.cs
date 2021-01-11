using Infrastructure.Interfaces.Standard;

namespace Infrastructure.Interfaces.Domain.Standard
{
    public interface IDomainRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
    }
}
