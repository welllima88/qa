using System.Collections.Generic;
using SIX.SCS.QA.Selenium.Extension;

namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium.TestObjects.Terminal.Dashboard.Brand
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