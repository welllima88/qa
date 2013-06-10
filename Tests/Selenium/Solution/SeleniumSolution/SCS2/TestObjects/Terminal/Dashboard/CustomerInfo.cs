using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension;

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
            get { return Driver.FindAdaptedElement(By.CssSelector(Dashboard.CustomerInfo_Name)); }
        }

        public IWebElementAdapter Adress
        {
            get { return Driver.FindAdaptedElement(By.CssSelector(Dashboard.CustomerInfo_Adress)); }
        }

        public IWebElementAdapter Info
        {
            get { return Driver.FindAdaptedElement(By.CssSelector(Dashboard.CustomerInfo_Info)); }
        }

        public IWebElementAdapter Id
        {
            get { return Driver.FindAdaptedElement(By.CssSelector(Dashboard.CustomerInfo_Id)); }
        }
    }
}