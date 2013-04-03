using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Extension.TestObjects;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Terminal.Dashboard.Brand
{
    public class Pms : WebObject
    {
        public Pms(IWebDriverAdapter driver) : base(driver)
        {
        }

        public IWebElementAdapter NetAdress
        {
            get { return Driver.FindAdaptedElement(By.CssSelector("#PMSNetAddress")); }
        }
    }
}