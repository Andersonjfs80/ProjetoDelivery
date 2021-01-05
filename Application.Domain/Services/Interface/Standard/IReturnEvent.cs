using Application.Domain.Services.Domain;
using System;

namespace Application.Domain
{
    public interface IReturnEvent<TEntity> : IGenericReturn
    {
        TEntity Result { get; set; }
    }
}
