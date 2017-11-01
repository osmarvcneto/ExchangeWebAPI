using CurrencyExchangeAPI.Domain.Entities;
using System.Collections.Generic;

namespace CurrencyExchangeAPI.Domain.Interfaces.Repositories
{
    public interface ICurrencyRepository : IRepositoryBase<Currency>
    {
        Currency GetCurrency(string code);

        IEnumerable<Currency> GetAll();
    }
}
