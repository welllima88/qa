using OpenQA.Selenium;
using Six.Scs.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.SearchResult
{
    public class LocationResult : WebObject
    {
        public static IWebElementAdapter Result()
        {
            return
                WebDriver.FindAdaptedElement(
                    By.CssSelector("div#locationDiv tbody#locationResult tr td a#locationLink[href*='/Location/']"));
        }
    }
}