using OpenQA.Selenium;
using Six.Test.Selenium.WebDriver.WebElements;

namespace Six.Scs.Test.View.User
{
    public class List : WebObject
    {
        public static IWebElementAdapter UserCreate
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("td#content button[name='create']")); }
        }
    }
}