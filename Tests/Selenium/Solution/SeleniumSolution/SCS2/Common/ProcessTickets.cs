using OpenQA.Selenium;
using Six.Scs.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.Common
{
    // TODO check locator!
    public class ProcessTickets : WebObject
    {
        public static IWebElementAdapter Oldest
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("ul#ElementHistoryList")); }
        }

        public static IWebElementAdapter Newest
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("ul#BatchHistoryList")); }
        }

        public static IWebElementAdapter Container
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("ul#TicketList")); }
        }
    }
}