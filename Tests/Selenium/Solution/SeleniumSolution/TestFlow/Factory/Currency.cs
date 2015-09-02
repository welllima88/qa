using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Six.Scs.Test.Factory
{
    public class Currency
    {
        public static IEnumerable<Model.Brand.Currency> StandardCurrencies()
        {
            return new Collection<Model.Brand.Currency>
            {
                new Model.Brand.Currency
                {
                    IsoCode = "CHF"
                }
                ,
                new Model.Brand.Currency
                {
                    IsoCode = "EUR"
                }
            };
        }
    }
}