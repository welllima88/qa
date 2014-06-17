using OpenQA.Selenium;
using Six.Scs.Tests.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.Tests.Selenium.Extension.TestObjects.Common
{
    public class RecentElements : WebObject
    {
        public static IWebElement Latest
        {
            get { return WebDriver.FindElement(By.CssSelector(CommonRes.RecentElements_MostRecent)); }
        }
    }
}