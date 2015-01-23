using OpenQA.Selenium;
using Six.Scs.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.Common.Menu
{
    public class TicketMenu : WebObject
    {
        public static IWebElementAdapter NotAssigned
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(
                        By.CssSelector("td#leftHandMenu a[href*='/TicketIntegration/UnAssignedTickets/']"));
            }
        }

        public static IWebElementAdapter MyGroup
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(
                        By.CssSelector("td#leftHandMenu a[href*='/TicketIntegration/MyGroupTickets/']"));
            }
        }

        public static IWebElementAdapter My
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(
                        By.CssSelector("td#leftHandMenu a[href*='/TicketIntegration/MyPersonalTickets/']"));
            }
        }

        public static IWebElementAdapter Installations
        {
            get
            {
                return WebDriver.FindAdaptedElement(By.CssSelector("a[href*='/InstallationTicket/InstallationTicket']"));
            }
        }
    }
}