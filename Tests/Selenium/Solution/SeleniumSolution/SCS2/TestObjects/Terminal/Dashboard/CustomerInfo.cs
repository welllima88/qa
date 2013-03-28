using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Extension.TestObjects;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Terminal.Dashboard
{
    /// <summary>
    /// Customer info object that represent the fix part in terminal dash board which shows customer infos
    /// </summary>
    public class CustomerInfo : WebObject
    {
        public CustomerInfo(IWebDriverAdapter driver) : base(driver)
        {
        }

        public IWebElementAdapter Name
        {
            get { return Driver.FindAdaptedElement(By.CssSelector("portletSummaryColumn>#TD_Customer_Name")); }
        }

        public IWebElementAdapter Info
        {
            get { return Driver.FindAdaptedElement(By.CssSelector("portletSummaryColumn>#TD_Customer_Info")); }
        }

        public IWebElementAdapter Id
        {
            get { return Driver.FindAdaptedElement(By.CssSelector("portletSummaryColumn>#TD_Customer_Id")); }
        }
    }
}