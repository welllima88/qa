using OpenQA.Selenium;

namespace SIX.SCS.QA.Selenium.Extension.TestObjects.SearchResult
{
    public class LocationResult : SearchResults
    {
        public LocationResult()
        {
            Prefix = "div#locationDiv.container ";
        }

        public static IWebElement Result()
        {
            return WebDriver.FindAdaptedElement(By.CssSelector("tbody#locationResult a#locationLink"));
        }
    }
}