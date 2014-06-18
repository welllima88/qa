using OpenQA.Selenium;
using Six.Scs.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.Extension.TestObjects.User
{
    public class UserList : WebObject
    {
        public static IWebElement UserCreate
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("td#content button[name='create']")); }
        }
    }
}