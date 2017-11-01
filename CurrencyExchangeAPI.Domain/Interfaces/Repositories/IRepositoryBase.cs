using CurrencyExchangeAPI.Domain.Interfaces.Entities;

namespace CurrencyExchangeAPI.Domain.Interfaces.Repositories
{
    public interface IRepositoryBase<TEntity> where TEntity : IEntityBase
    {
    }
}
