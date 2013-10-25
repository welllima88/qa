using OpenQA.Selenium;

namespace SIX.SCS.QA.Selenium.Extension.TestObjects.Terminal.Dashboard
{
    /// <summary>
    ///     Customer info object that represent the fix part in terminal dash board which shows customer infos
    /// </summary>
    public class CustomerInfo : WebObject
    {
        public static IWebElementAdapter Name
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector(DashboardRes.CustomerInfo_Name)); }
        }

        public static IWebElementAdapter Adress
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector(DashboardRes.CustomerInfo_Adress)); }
        }

        public static IWebElementAdapter Info
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector(DashboardRes.CustomerInfo_Info)); }
        }

        public static IWebElementAdapter Id
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector(DashboardRes.CustomerInfo_Id)); }
        }
    }
}