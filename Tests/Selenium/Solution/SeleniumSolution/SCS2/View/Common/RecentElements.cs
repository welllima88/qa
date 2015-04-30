using OpenQA.Selenium;
using Six.Test.Selenium.WebDriver.WebElements;

namespace Six.Scs.Test.View.Common
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