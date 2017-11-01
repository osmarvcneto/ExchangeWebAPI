using CurrencyExchangeAPI.Domain.Interfaces.Entities;

namespace CurrencyExchangeAPI.Services.Interfaces
{
    public interface IServiceBase<TEntity> where TEntity : IEntityBase
    {
    }
}
