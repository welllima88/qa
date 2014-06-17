using OpenQA.Selenium;

namespace Six.Scs.Tests.Selenium.Extension.TestObjects.SearchResult
{
    public class UserResult : SearchResults
    {
        public UserResult()
        {
            Prefix = "div#userDiv ";
        }

        public static IWebElement First()
        {
            IWebElement element =
                WebDriver.FindAdaptedElement(
                    By.CssSelector(
                        "div#userDiv tbody#userResult tr td a#userLink[href*='/User/Index?UserName=']"));
            return element;
        }
    }
}