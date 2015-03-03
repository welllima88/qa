using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using Six.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.Terminal.Dashboard.Portlets.Support
{
    public class TroubleTickets : PortletViewBase
    {
        private const string _prefix = "div#frame_SupportTicketPortlet ";

        public static Priority Priority
        {
            get { return new Priority(); }
        }

        public static string Category
        {
            set
            {
                WebDriver.FindAdaptedElement(By.Id("InputIncidentCategory")).TextField().TypeText(value);
                WebDriver.FindAdaptedElements(By.CssSelector("ul.ui-autocomplete>li.ui-menu-item>a"))
                    .FirstOrDefault(e => e.Text.Contains(value)).Click();
            }
        }

        public static IEnumerable<string> Solution
        {
            set
            {
                foreach (string solution in value)
                {
                    WebDriver.FindAdaptedElement(By.CssSelector("button.dropdown-toggle")).Click();
                    WebDriver.FindAdaptedElements(By.CssSelector("ul#resolutionDropdown li"))
                        .Where(e => e.Text.Contains(solution));
                }
            }
        }

        public static string Mobile
        {
            set { WebDriver.FindAdaptedElement(By.Id("Contact_Mobile")).TextField().TypeText(value); }
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

        public static string ExternReferenceId
        {
            set { WebDriver.FindAdaptedElement(By.Id("ExtReferenceId")).TextField().TypeText(value); }
        }

        public static string Contact
        {
            set { WebDriver.FindAdaptedElement(By.Id("Contact_FullName")).TextField().TypeText(value); }
        }

        public static string Forward
        {
            set { WebDriver.FindAdaptedElement(By.Id("ForwardToTeamId")).Selector().SelectByText(value); }
        }

        public static string MyTeam
        {
            set { WebDriver.FindAdaptedElement(By.Id("TeamId")).Selector().SelectByText(value); }
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

        public static void New()
        {
            WebDriver.FindAdaptedElement(By.Id("ShowNewIncidentControl")).Click();
            WebDriver.WebDriverWait()
                .Until(d => d.FindElement(By.Id("IncidentNew")).GetAttribute("class").Contains("active"));
        }

        public static void Incidents()
        {
            WebDriver.FindAdaptedElement(By.Id("ShowNewIncidentControl")).Click();
            WebDriver.WebDriverWait()
                .Until(d => d.FindElement(By.Id("IncidentList")).GetAttribute("class").Contains("active"));
        }

        public static string FetchIdByPopup()
        {
            string ticketNo = WebDriver.SwitchTo().Alert().Text;
            WebDriver.SwitchTo().Alert().Accept();
            return ticketNo;
        }
    }
}