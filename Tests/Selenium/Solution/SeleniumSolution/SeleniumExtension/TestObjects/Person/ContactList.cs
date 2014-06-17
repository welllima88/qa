using OpenQA.Selenium;
using Six.Scs.Tests.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.Tests.Selenium.Extension.TestObjects.Person
{
    public class ContactList : WebObject
    {
        public static IWebElement First()
        {
            return WebDriver.FindAdaptedElement(By.CssSelector("tbody tr td a[href*='/Person?PersonId=']"));
        }
    }
}