using OpenQA.Selenium;

namespace SIX.SCS.QA.Selenium.Extension.TestObjects.Terminal.Dashboard
{
    /// <summary>
    ///     Customer info object that represent the fix part in terminal dash board which shows customer infos
    /// </summary>
    public class CustomerInfo : WebObject
    {
        public IWebElementAdapter Name
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector(Dashboard.CustomerInfo_Name)); }
        }

        public IWebElementAdapter Adress
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector(Dashboard.CustomerInfo_Adress)); }
        }

        public IWebElementAdapter Info
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector(Dashboard.CustomerInfo_Info)); }
        }

        public IWebElementAdapter Id
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector(Dashboard.CustomerInfo_Id)); }
        }
    }
}