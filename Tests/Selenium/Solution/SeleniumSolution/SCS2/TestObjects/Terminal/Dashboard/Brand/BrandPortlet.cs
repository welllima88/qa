using System.Collections.Generic;
using SIX.SCS.QA.Selenium.Extension;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Terminal.Dashboard.Brand
{
    public class BrandPortlet : PortletViewBase
    {
        public List<Acquirer> Acquirers;
        public Pms Pms;
        public ServiceCenter ServiceCenter;

        public BrandPortlet(IWebDriverAdapter driver) : base(driver)
        {
            PortletId = "div#frame_BrandPortlet";
            ServiceCenter = new ServiceCenter(driver);
            Pms = new Pms(driver);
            Acquirers = new List<Acquirer>(5);
        }
    }
}