using OpenQA.Selenium;
using Six.Test.Selenium.WebDriver.WebElements;

namespace Six.Scs.Test.View.Person
{
    public class List : WebObject
    {
        public static IWebElementAdapter First()
        {
            return WebDriver.FindAdaptedElement(By.CssSelector("tbody tr td a[href*='/Person?PersonId=']"));
        }
    }
}