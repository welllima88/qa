using OpenQA.Selenium;
using Six.Test.Selenium.WebDriver.WebElements;
using IWebElement = Six.Test.Selenium.WebDriver.WebElements.IWebElement;

namespace Six.Scs.Test.UI.Administration.Agency
{
    public class List : WebObject
    {
        public static IWebElement Create
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("button[name='create']")); }
        }
    }
}