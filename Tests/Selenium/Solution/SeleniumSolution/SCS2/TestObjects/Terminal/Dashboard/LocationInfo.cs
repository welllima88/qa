using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Extension.TestObjects;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Terminal.Dashboard
{
    /// <summary>
    /// Location info object that represent the fix part in terminal dash board which shows location infos
    /// </summary>
    public class LocationInfo : WebObject
    {
        public LocationInfo(IWebDriverAdapter driver) : base(driver)
        {
        }

        public IWebElementAdapter Name
        {
            get { return Driver.FindAdaptedElement(By.CssSelector("portletSummaryColumn>#TD_Location_Name")); }
        }

        public IWebElementAdapter Ep2Id
        {
            get { return Driver.FindAdaptedElement(By.CssSelector("portletSummaryColumn>#TD_Location_Id")); }
        }

        public IWebElementAdapter Adress
        {
            get { return Driver.FindAdaptedElement(By.CssSelector("portletSummaryColumn>#TD_Location_Address")); }
        }
    }
}