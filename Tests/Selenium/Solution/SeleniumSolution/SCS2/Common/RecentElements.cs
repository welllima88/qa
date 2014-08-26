using OpenQA.Selenium;
using Six.Scs.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.Common
{
    public class RecentElements : WebObject
    {
        public static IWebElementAdapter Latest
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("div#ElementHistoryList ul#ElementHistoryList>li>a")); }
        }
    }
}