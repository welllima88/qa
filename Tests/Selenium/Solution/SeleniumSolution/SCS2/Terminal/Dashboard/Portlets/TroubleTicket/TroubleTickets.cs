using OpenQA.Selenium;
using Six.Scs.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.Terminal.Dashboard.Portlets.TroubleTicket
{
    public class TroubleTickets : PortletViewBase
    {
        private const string _prefix = "div#frame_SupportTicketPortlet";

        public static Priority Priority { get; set; }

        public static string Category
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector("InputIncidentCategory")).TextField().TypeText(value); }
        }

        public static string Solution
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector("resolutionDropdown")).TextField().TypeText(value); }
        }

        public static string Mobile
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector("InputIncidentCategory")).TextField().TypeText(value); }
        }

        public static string AvailableTime
        {
            set { WebDriver.FindAdaptedElement(By.Id("Contact_Availability")).TextField().TypeText(value); }
        }

        public static string Phone
        {
            set { WebDriver.FindAdaptedElement(By.Id("Contact_Phone")).TextField().TypeText(value); }
        }

        public static string Fax
        {
            set { WebDriver.FindAdaptedElement(By.Id("Contact_Fax")).TextField().TypeText(value); }
        }

        public static string Email
        {
            set { WebDriver.FindAdaptedElement(By.Id("Contact_EMail")).TextField().TypeText(value); }
        }

        public static string Contact
        {
            set { WebDriver.FindAdaptedElement(By.Id("Contact_FullName")).TextField().TypeText(value); }
        }

        public static string Forward
        {
            set { WebDriver.FindAdaptedElement(By.Id("TeamId")).Selector().SelectByText(value); }
        }

        public static string MyTeam
        {
            set { WebDriver.FindAdaptedElement(By.Id("ForwardToTeamId")).Selector().SelectByText(value); }
        }

        public static IWebElementAdapter New
        {
            get { return WebDriver.FindAdaptedElement(By.Id("ShowNewIncidentControl")); }
        }

        public static string Description
        {
            set { WebDriver.FindAdaptedElement(By.Id("Notes")).TextArea().TypeText(value); }
        }

        public static IWebElementAdapter Save
        {
            get { return WebDriver.FindAdaptedElement(By.Id("save")); }
        }

        public static IWebElementAdapter SaveAndClose
        {
            get { return WebDriver.FindAdaptedElement(By.Id("SaveAndClose")); }
        }
    }
}