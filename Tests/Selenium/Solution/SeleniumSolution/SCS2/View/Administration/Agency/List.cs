using OpenQA.Selenium;
using Six.Test.Selenium.WebDriver.WebElements;

namespace Six.Scs.Test.View.Administration.Agency
{
    public class List : WebObject
    {
        public static IWebElementAdapter Create
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("button[name='create']")); }
        }
    }
}