using OpenQA.Selenium;
using Six.Scs.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.Terminal.Dashboard
{
    /// <summary>
    ///     Location info object that represent the fix part in terminal dash board which shows location infos
    /// </summary>
    public class LocationInfo : WebObject
    {
        public static string CompanyName
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector(DashboardRes.LocationInfo_Name)).Text; }
        }

        public static string Ep2Id
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector(DashboardRes.LocationInfo_Ep2Id)).Text; }
        }

        public static string Adress
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector(DashboardRes.LocationInfo_Adress)).Text; }
        }
    }
}