using OpenQA.Selenium;
using Six.Test.Selenium.WebDriver.WebElements;
using IWebElement = Six.Test.Selenium.WebDriver.WebElements.IWebElement;

namespace Six.Scs.Test.View.User
{
    public class Delete : WebObject
    {
        public static IWebElement ConfirmButton
        {
            get { return WebDriver.FindAdaptedElement(By.Id("delete")); }
        }

        public static IWebElement Description
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("td#content div.row div p")); }
        }
    }
}