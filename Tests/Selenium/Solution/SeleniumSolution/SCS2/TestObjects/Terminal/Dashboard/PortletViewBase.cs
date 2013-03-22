using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Extension.TestObjects;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Terminal.Dashboard
{
    public abstract class PortletViewBase : WebObject
    {
        protected PortletViewBase(IWebDriverAdapter driver) : base(driver)
        {
            Suffix = " div.portletKeyValueRow div.treeGridValueCol";
            Prefix = "tbody div#dashboarditems div ";
        }

        protected string PortletId { get; set; }

        public IWebElement PortletTitle
        {
            get
            {
                return
                    Driver.FindElement(
                        By.CssSelector(Prefix + PortletId + "h1.portlet-header"));
            }
        }

        public IWebElement Refresh
        {
            get
            {
                return
                    Driver.FindElement(
                        By.CssSelector(Prefix + PortletId + "h1 span[title='refresh']"));
            }
        }

        public IWebElement Minimize
        {
            get
            {
                return
                    Driver.FindElement(
                        By.CssSelector(Prefix + PortletId + "h1 span[title='minimize']"));
            }
        }
    }
}