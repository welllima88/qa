using SIX.SCS.QA.Selenium.Extension;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Terminal.Dashboard
{
    public class TroubleTicketsPortlet : PortletViewBase
    {
        public TroubleTicketsPortlet(IWebDriverAdapter driver) : base(driver)
        {
            PortletId = "div#frame_SupportTicketPortlet";
        }
    }
}