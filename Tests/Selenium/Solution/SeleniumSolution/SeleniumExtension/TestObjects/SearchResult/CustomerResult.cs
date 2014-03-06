using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension.Selenium.WebElements;

namespace SIX.SCS.QA.Selenium.Extension.TestObjects.SearchResult
{
    public class CustomerResult : WebObject
    {
        public static IWebElement Result()
        {
            IWebElement element =
                WebDriver.FindAdaptedElement(
                    By.CssSelector(
                        "div#customerDiv tbody#customerResult tr td a#customerLink[href*='/Customer/?CustomerId=']"));
            return element;
        }
    }
}