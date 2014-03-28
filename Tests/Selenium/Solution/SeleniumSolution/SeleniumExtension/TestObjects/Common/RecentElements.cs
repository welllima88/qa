using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension.Selenium.WebElements;

namespace SIX.SCS.QA.Selenium.Extension.TestObjects.Common
{
    public class RecentElements : WebObject
    {
        public static IWebElement Latest
        {
            get { return WebDriver.FindElement(By.CssSelector(CommonRes.RecentElements_MostRecent)); }
        }
    }
}