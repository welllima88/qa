using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;

namespace Six.Scs.Test.UI.Terminal.Dashboard.Portlets
{
    public class Contacts : PortletBase
    {
        public Contacts()
        {
            PortletId = "div#frame_ContactPortlet";
        }

        public static IEnumerable<string> CustomerContacts
        {
            get { return WebDriver.FindAdaptedElements(By.CssSelector("#CustomerContacts ul li")).Select(e => e.Text); }
        }
    }
}