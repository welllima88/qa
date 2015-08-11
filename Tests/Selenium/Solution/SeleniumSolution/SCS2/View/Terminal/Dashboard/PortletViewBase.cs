using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Six.Test.Selenium.WebDriver.WebElements;
using IWebElement = Six.Test.Selenium.WebDriver.WebElements.IWebElement;

namespace Six.Scs.Test.View.Terminal.Dashboard
{
    public abstract class PortletViewBase : WebObject
    {
        public static readonly WebDriverWait WebDriverWait = WebDriver.WebDriverWait();
        protected static string PortletId;

        protected PortletViewBase()
        {
            Suffix = " div.portletKeyValueRow div.treeGridValueCol";
            Prefix = "tbody div#dashboarditems div ";
        }

        public IWebElement PortletTitle
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(
                        By.CssSelector(Prefix + PortletId + "h1.portlet-header"));
            }
        }

        public IWebElement Refresh
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(
                        By.CssSelector(Prefix + PortletId + "h1 span[title='refresh']"));
            }
        }

        public IWebElement Minimize
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
            var w = WebDriver.WebDriverWait();
            w.Until(d => d.FindElements(By.CssSelector("div.overly-loading")).Count == 0);
        }

        public static void OpenTree(string cssLocator)
        {
            var w = WebDriver.WebDriverWait();
            w.Until(d => d.FindElement(By.CssSelector(cssLocator + ".jstree-closed>ins"))).Click();
        }
    }
}