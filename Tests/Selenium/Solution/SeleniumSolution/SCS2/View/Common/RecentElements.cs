using OpenQA.Selenium;
using Six.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.View.Common
{
    public class RecentElements : WebObject
    {
        public static IWebElementAdapter Latest
        {
            get
            {
                return WebDriver.FindAdaptedElement(By.CssSelector("div#ElementHistoryList ul#ElementHistoryList>li>a"));
            }
        }
    }
}