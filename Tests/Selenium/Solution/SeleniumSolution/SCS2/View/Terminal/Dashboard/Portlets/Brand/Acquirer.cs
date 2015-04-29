using System.Collections.Generic;
using Six.Test.Selenium.WebDriver.WebElements;

namespace Six.Scs.Test.View.Terminal.Dashboard.Portlets.Brand
{
    public class Acquirer : WebObject
    {
        public List<BrandContract> Brands;

        public Acquirer()
        {
            Brands = new List<BrandContract>(5);
        }
    }
}