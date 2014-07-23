using OpenQA.Selenium;
using Six.Scs.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.Common.Menu
{
    public class TicketMenu : WebObject
    {
        public static IWebElementAdapter NotAssigned
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector(MenuRes.TicketMenu_NotAssigned)); }
        }

        public static IWebElementAdapter MyGroup
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector(MenuRes.TicketMenu_MyGroup)); }
        }

        public static IWebElementAdapter My
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector(MenuRes.TicketMenu_My)); }
        }

        public static IWebElementAdapter Installations
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(By.CssSelector("a[href*='/TicketIntegration/DeliveryTicketsInstall/']"));
            }
        }
    }
}