using OpenQA.Selenium;
using Six.Scs.Tests.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.Tests.Selenium.Extension.TestObjects.Common
{
    public class SiteContent : WebObject
    {
        public static string Header
        {
            get { return WebDriver.FindElement(By.CssSelector("tbody td#content h1")).Text; }
        }
    }
}