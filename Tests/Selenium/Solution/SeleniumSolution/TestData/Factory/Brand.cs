using System.Collections.Generic;
using System.Collections.ObjectModel;
using Six.Scs.QA.TestData.ValueObjects.Brand;

namespace Six.Scs.QA.TestData.Factory
{
    public static class Brand
    {
        public static IEnumerable<ValueObjects.Brand.Brand> SixBrands()
        {
            return new Collection<ValueObjects.Brand.Brand>
            {
                new OnUs
                {
                    Status = true,
                    Dcc = true,
                    Currencies = Currency.StandardCurrencies(),
                    DccBaseCurrency = new ValueObjects.Brand.Currency
                    {
                        IsoCode = "CHF"
                    },
                    ContactlessCapabilities = "contact only"
                },
                new OnUs
                {
                    Status = true,
                    Dcc = true,
                    Currencies = Currency.StandardCurrencies(),
                    DccBaseCurrency = new ValueObjects.Brand.Currency
                    {
                        IsoCode = "EUR"
                    },
                    ContactlessCapabilities = "contact and contactless"
                }
            };
        }
    }
}