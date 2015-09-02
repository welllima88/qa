using OpenQA.Selenium;
using Six.Test.Selenium.WebDriver.WebElements;
using IWebElement = Six.Test.Selenium.WebDriver.WebElements.IWebElement;

namespace Six.Scs.Test.UI.Person
{
    public class List : WebObject
    {
        public static IWebElement First()
        {
            return WebDriver.FindAdaptedElement(By.CssSelector("tbody tr td a[href*='/Person?PersonId=']"));
        }
    }
}