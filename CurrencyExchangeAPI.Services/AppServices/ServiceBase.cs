using CurrencyExchangeAPI.Domain.Interfaces.Entities;
using CurrencyExchangeAPI.Domain.Interfaces.Repositories;
using CurrencyExchangeAPI.Services.Interfaces;

namespace CurrencyExchangeAPI.Services.AppServices
{
    public class ServiceBase<TEntity> : IServiceBase<TEntity> where TEntity : IEntityBase
    {
        private readonly IRepositoryBase<TEntity> repositoryBase;

        public ServiceBase(IRepositoryBase<TEntity> repository)
        {
            repositoryBase = repository;
        }
    }
}
