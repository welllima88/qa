using OpenQA.Selenium;
using Six.Scs.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.Person
{
    public class ContactList : WebObject
    {
        public static IWebElement First()
        {
            return WebDriver.FindAdaptedElement(By.CssSelector("tbody tr td a[href*='/Person?PersonId=']"));
        }
    }
}