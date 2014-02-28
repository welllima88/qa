using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension.Selenium.WebElements;

namespace SIX.SCS.QA.Selenium.Extension.TestObjects.SearchResult
{
    public class LocationResult : WebObject
    {
        public static IWebElement Result()
        {
            return
                WebDriver.FindElement(
                    By.CssSelector("div#locationDiv tbody#locationResult tr td a#locationLink[href*='/Location/']"));
        }
    }
}