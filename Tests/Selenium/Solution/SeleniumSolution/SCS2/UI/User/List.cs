using OpenQA.Selenium;
using Six.Test.Selenium.WebDriver.WebElements;
using IWebElement = Six.Test.Selenium.WebDriver.WebElements.IWebElement;

namespace Six.Scs.Test.UI.User
{
    public class List : WebObject
    {
        public static IWebElement UserCreate
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("td#content button[name='create']")); }
        }
    }
}