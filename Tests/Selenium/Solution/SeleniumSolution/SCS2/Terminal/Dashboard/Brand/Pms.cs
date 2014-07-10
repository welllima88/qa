using OpenQA.Selenium;
using Six.Scs.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.Terminal.Dashboard.Brand
{
    public class Pms : WebObject
    {
        public static IWebElementAdapter NetAdress
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("#PMSNetAddress")); }
        }
    }
}