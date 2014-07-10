using OpenQA.Selenium;
using Six.Scs.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.Common.Menu
{
    public class TicketMenu : WebObject
    {
        public static IWebElement NotAssigned
        {
            get { return WebDriver.FindElement(By.CssSelector(MenuRes.TicketMenu_NotAssigned)); }
        }

        public static IWebElement MyGroup
        {
            get { return WebDriver.FindElement(By.CssSelector(MenuRes.TicketMenu_MyGroup)); }
        }

        public static IWebElement My
        {
            get { return WebDriver.FindElement(By.CssSelector(MenuRes.TicketMenu_My)); }
        }

        public static IWebElement Installations
        {
            get
            {
                return WebDriver.FindElement(By.CssSelector("a[href*='/TicketIntegration/DeliveryTicketsInstall/']"));
            }
        }
    }
}