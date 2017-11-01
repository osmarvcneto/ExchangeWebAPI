using CurrencyExchangeAPI.Domain.Entities;
using System.Collections.Generic;

namespace CurrencyExchangeAPI.Services.Interfaces
{
    public interface ICurrencyService : IServiceBase<Currency>
    {
        Currency GetCurrency(string code);

        IEnumerable<Currency> GetAll();
    }
}
