using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension.Selenium.WebElements;

namespace SIX.SCS.QA.Selenium.Extension.TestObjects.Terminal.Dashboard
{
    /// <summary>
    ///     Location info object that represent the fix part in terminal dash board which shows location infos
    /// </summary>
    public class LocationInfo : WebObject
    {
        public static IWebElementAdapter Name
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector(DashboardRes.LocationInfo_Name)); }
        }

        public static IWebElementAdapter Ep2Id
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector(DashboardRes.LocationInfo_Ep2Id)); }
        }

        public static IWebElementAdapter Adress
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector(DashboardRes.LocationInfo_Adress)); }
        }
    }
}