using OpenQA.Selenium;

namespace SIX.SCS.QA.Selenium.Extension.TestObjects.Terminal.Dashboard
{
    /// <summary>
    ///     Location info object that represent the fix part in terminal dash board which shows location infos
    /// </summary>
    public class LocationInfo : WebObject
    {
        public IWebElementAdapter Name
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector(Dashboard.LocationInfo_Name)); }
        }

        public IWebElementAdapter Ep2Id
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector(Dashboard.LocationInfo_Ep2Id)); }
        }

        public IWebElementAdapter Adress
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector(Dashboard.LocationInfo_Adress)); }
        }
    }
}