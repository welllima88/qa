using OpenQA.Selenium;
using Six.Scs.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.Terminal.Dashboard
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