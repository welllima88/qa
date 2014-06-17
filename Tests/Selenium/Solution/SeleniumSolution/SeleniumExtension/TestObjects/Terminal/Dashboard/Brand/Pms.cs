using OpenQA.Selenium;
using Six.Scs.Tests.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.Tests.Selenium.Extension.TestObjects.Terminal.Dashboard.Brand
{
    public class Pms : WebObject
    {
        public static IWebElementAdapter NetAdress
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("#PMSNetAddress")); }
        }
    }
}