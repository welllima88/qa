using System.Collections.Generic;
using SIX.SCS.QA.Selenium.Extension;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Terminal.Dashboard.Brand
{
    public class BrandPortlet : PortletViewBase
    {
        public List<Acquirer> Acquirers;
        public Pms Pms;
        public ServiceCenter ServiceCenter;
        // https://gateint.telekurs.ch/zebrac-qa-l/zebrac-qa-l/TerminalDashboard/?CustomerId=85036&LocationId=9fbbb2b4-839e-47cb-b736-189bbce86c17&TerminalId=30381638
        public BrandPortlet(IWebDriverAdapter driver) : base(driver)
        {
            PortletId = "div#frame_BrandPortlet";
            ServiceCenter = new ServiceCenter(driver);
            Pms = new Pms(driver);
            Acquirers = new List<Acquirer>(5);
        }
    }
}