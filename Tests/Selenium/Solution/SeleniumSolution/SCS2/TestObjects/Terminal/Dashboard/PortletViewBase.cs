using OpenQA.Selenium;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Terminal.Dashboard
{
    public abstract class PortletViewBase
    {
        protected static string Pre;
        protected static string Suf = " div.portletKeyValueRow div.treeGridValueCol";
        protected readonly IWebDriver Driver;

        protected PortletViewBase(IWebDriver driver)
        {
            Driver = driver;
        }
    }
}