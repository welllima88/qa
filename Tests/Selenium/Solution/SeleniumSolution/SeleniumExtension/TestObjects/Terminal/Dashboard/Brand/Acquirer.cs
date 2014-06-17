using System.Collections.Generic;
using Six.Scs.Tests.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.Tests.Selenium.Extension.TestObjects.Terminal.Dashboard.Brand
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