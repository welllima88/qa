using SIX.SCS.QA.Selenium.Extension;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Terminal.Dashboard
{
    public class ContactsPortlet : PortletViewBase
    {
        public ContactsPortlet(IWebDriverAdapter driver) : base(driver)
        {
            PortletId = "div#frame_ContactPortlet";
        }
    }
}