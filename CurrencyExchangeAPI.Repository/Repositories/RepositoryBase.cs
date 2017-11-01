using CurrencyExchangeAPI.Domain.Interfaces.Entities;
using CurrencyExchangeAPI.Domain.Interfaces.Repositories;
using System;

namespace CurrencyExchangeAPI.Repository.Repositories
{
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : IEntityBase
    {
    }
}
