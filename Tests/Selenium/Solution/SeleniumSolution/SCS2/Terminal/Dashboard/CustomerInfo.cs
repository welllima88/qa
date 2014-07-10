using OpenQA.Selenium;
using Six.Scs.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.Terminal.Dashboard
{
    /// <summary>
    ///     Customer info object that represent the fix part in terminal dash board which shows customer infos
    /// </summary>
    public class CustomerInfo : WebObject
    {
        public static string Name
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector(DashboardRes.CustomerInfo_Name)).Text; }
        }

        public static string Adress
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector(DashboardRes.CustomerInfo_Adress)).Text; }
        }

        public static string Info
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector(DashboardRes.CustomerInfo_Info)).Text; }
        }

        public static string Number
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector(DashboardRes.CustomerInfo_Id)).Text; }
        }
    }
}