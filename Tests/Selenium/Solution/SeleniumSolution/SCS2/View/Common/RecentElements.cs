using OpenQA.Selenium;
using Six.Test.Selenium.WebDriver.WebElements;
using IWebElement = Six.Test.Selenium.WebDriver.WebElements.IWebElement;

namespace Six.Scs.Test.View.Common
{
    public class RecentElements : WebObject
    {
        public static IWebElement Latest
        {
            get
            {
                return WebDriver.FindAdaptedElement(By.CssSelector("div#ElementHistoryList ul#ElementHistoryList>li>a"));
            }
        }
    }
}