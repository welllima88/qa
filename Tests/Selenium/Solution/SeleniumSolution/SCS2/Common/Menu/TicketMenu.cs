using OpenQA.Selenium;
using Six.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.Common.Menu
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