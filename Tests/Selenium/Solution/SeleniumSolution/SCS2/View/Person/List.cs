using OpenQA.Selenium;
using Six.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Application.View.Person
{
    public class List : WebObject
    {
        public static IWebElementAdapter First()
        {
            return WebDriver.FindAdaptedElement(By.CssSelector("tbody tr td a[href*='/Person?PersonId=']"));
        }
    }
}