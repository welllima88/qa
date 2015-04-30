using OpenQA.Selenium;
using Six.Test.Selenium.WebDriver.WebElements;

namespace Six.Scs.Test.View.Common.Menu
{
    public class TicketMenu : WebObject
    {
        public static IWebElementAdapter Installations
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(
                        By.CssSelector("td#leftHandMenu a[href*='/InstallationTicket/InstallationTicket']"));
            }
        }
    }
}