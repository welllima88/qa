using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Extension.TestObjects;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Terminal.Dashboard
{
    public abstract class PortletViewBase: WebObject
    {
        protected static string Pre;
        protected static string Suf = " div.portletKeyValueRow div.treeGridValueCol";
        
        protected PortletViewBase(IWebDriverAdapter driver):base(driver)
        {         
        }
    }
}