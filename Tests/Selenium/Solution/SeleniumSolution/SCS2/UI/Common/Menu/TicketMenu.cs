using OpenQA.Selenium;
using Six.Test.Selenium.WebDriver.WebElements;
using IWebElement = Six.Test.Selenium.WebDriver.WebElements.IWebElement;

namespace Six.Scs.Test.UI.Common.Menu
{
    public class TicketMenu : WebObject
    {
        public static IWebElement Installations
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