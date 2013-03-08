using System;
using SIX.SCS.QA.Selenium.Extension;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Terminal.Dashboard
{
    public class CommonTerminalInfo : PortletViewBase
    {
        public CommonTerminalInfo(IWebDriverAdapter webDriver) : base(webDriver)
        {
        }

        public CustomerInfo Customer
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public LocationInfo Location
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public TerminalInfo Terminal
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    }
}