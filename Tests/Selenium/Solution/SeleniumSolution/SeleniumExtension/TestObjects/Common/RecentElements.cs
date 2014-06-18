using OpenQA.Selenium;
using Six.Scs.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.Extension.TestObjects.Common
{
    public class RecentElements : WebObject
    {
        public static IWebElement Latest
        {
            get { return WebDriver.FindElement(By.CssSelector(CommonRes.RecentElements_MostRecent)); }
        }
    }
}