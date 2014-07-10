using OpenQA.Selenium;
using Six.Scs.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.SearchResult
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