using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Six.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.Terminal.Dashboard
{
    public abstract class PortletViewBase : WebObject
    {
        public static readonly WebDriverWait WebDriverWait = WebDriver.WebDriverWait();

        protected PortletViewBase()
        {
            Suffix = " div.portletKeyValueRow div.treeGridValueCol";
            Prefix = "tbody div#dashboarditems div ";
        }

        protected static string PortletId { get; set; }

        public IWebElementAdapter PortletTitle
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(
                        By.CssSelector(Prefix + PortletId + "h1.portlet-header"));
            }
        }

        public IWebElementAdapter Refresh
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(
                        By.CssSelector(Prefix + PortletId + "h1 span[title='refresh']"));
            }
        }

        public IWebElementAdapter Minimize
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(
                        By.CssSelector(Prefix + PortletId + "h1 span[title='minimize']"));
            }
        }

        public static void AllHasBeenLoaded()
        {
            WebDriverWait w = WebDriver.WebDriverWait();
            w.Until(d => d.FindElements(By.CssSelector("div.overly-loading")).Count == 0);
        }

        public static void OpenTree(string cssLocator)
        {
            WebDriverWait w = WebDriver.WebDriverWait();
            w.Until(d => d.FindElement(By.CssSelector(cssLocator + ".jstree-closed>ins"))).Click();
        }
    }
}