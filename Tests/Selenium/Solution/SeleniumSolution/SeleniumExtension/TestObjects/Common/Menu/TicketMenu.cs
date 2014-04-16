using OpenQA.Selenium;

namespace SIX.SCS.QA.Selenium.Extension.TestObjects.Common.Menu
{
    public class TicketMenu : MenuObject
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