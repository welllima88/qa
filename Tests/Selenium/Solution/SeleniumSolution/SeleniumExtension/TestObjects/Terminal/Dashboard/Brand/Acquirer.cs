using System.Collections.Generic;

namespace SIX.SCS.QA.Selenium.Extension.TestObjects.Terminal.Dashboard.Brand
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