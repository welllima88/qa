using System.Collections.Generic;
using Six.Scs.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.Terminal.Dashboard.Portlets.Brand
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