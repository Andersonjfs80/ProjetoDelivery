using Application.Domain.Services.Domain;
using System;

namespace Application.Domain
{
    public class ReturnEvent<TEntity> : GenericReturn, IReturnEvent<TEntity>
    {
        public TEntity Result { get; set; }
    }
}
