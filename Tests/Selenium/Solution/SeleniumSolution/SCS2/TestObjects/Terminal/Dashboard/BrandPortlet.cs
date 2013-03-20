using SIX.SCS.QA.Selenium.Extension;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Terminal.Dashboard
{
    public class BrandPortlet : PortletViewBase
    {
        public BrandPortlet(IWebDriverAdapter driver) : base(driver)
        {
            PortletId = "div#frame_BrandPortlet";
        }
    }
}