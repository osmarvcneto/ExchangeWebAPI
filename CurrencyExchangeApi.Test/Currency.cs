using CurrencyExchangeAPI.Repository.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CurrencyExchangeApi.Test
{
    [TestClass]
    public class CurrencyTest
    {
        [TestMethod]
        public void GetCurrency()
        {
            var respo = new CurrencyRepository().GetCurrency("usdt");

            Assert.IsNotNull(respo);
        }

        [TestMethod]
        public void GetAll()
        {
            var respo = new CurrencyRepository().GetAll();

            Assert.IsNotNull(respo);
        }
    }
}
