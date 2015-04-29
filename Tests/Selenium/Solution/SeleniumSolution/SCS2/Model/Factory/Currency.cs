using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Six.Scs.Test.Model.Factory
{
    public class Currency
    {
        public static IEnumerable<ValueObjects.Brand.Currency> StandardCurrencies()
        {
            return new Collection<ValueObjects.Brand.Currency>
            {
                new ValueObjects.Brand.Currency
                {
                    IsoCode = "CHF"
                }
                ,
                new ValueObjects.Brand.Currency
                {
                    IsoCode = "EUR"
                }
            };
        }
    }
}