using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension;

namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium.TestObjects.Terminal.Dashboard
{
    public abstract class PortletViewBase : WebObject
    {
        protected PortletViewBase()
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
                    WebDriver.FindElement(
                        By.CssSelector(Prefix + PortletId + "h1.portlet-header"));
            }
        }

        public IWebElement Refresh
        {
            get
            {
                return
                    WebDriver.FindElement(
                        By.CssSelector(Prefix + PortletId + "h1 span[title='refresh']"));
            }
        }

        public IWebElement Minimize
        {
            get
            {
                return
                    WebDriver.FindElement(
                        By.CssSelector(Prefix + PortletId + "h1 span[title='minimize']"));
            }
        }
    }
}