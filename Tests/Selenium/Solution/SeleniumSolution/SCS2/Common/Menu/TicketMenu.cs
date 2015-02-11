using OpenQA.Selenium;
using Six.Scs.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.Common.Menu
{
    public class TicketMenu : WebObject
    {
        public static IWebElementAdapter Installations
        {
            get
            {
                return WebDriver.FindAdaptedElement(By.CssSelector("a[href*='/InstallationTicket/InstallationTicket']"));
            }
        }
    }
}