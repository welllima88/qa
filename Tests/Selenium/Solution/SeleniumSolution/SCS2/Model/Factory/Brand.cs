using System.Collections.Generic;
using System.Collections.ObjectModel;
using Six.Scs.Test.Model.Brand;

namespace Six.Scs.Test.Model.Factory
{
    public static class Brand
    {
        public static IEnumerable<Model.Brand.Brand> SixBrands()
        {
            return new Collection<Model.Brand.Brand>
            {
                new OnUs
                {
                    Status = true,
                    Dcc = true,
                    Currencies = Currency.StandardCurrencies(),
                    DccBaseCurrency = new Model.Brand.Currency
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
                    DccBaseCurrency = new Model.Brand.Currency
                    {
                        IsoCode = "EUR"
                    },
                    ContactlessCapabilities = "contact and contactless"
                }
            };
        }
    }
}