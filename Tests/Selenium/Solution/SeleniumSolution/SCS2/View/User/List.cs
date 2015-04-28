using OpenQA.Selenium;
using Six.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Application.View.User
{
    public class List : WebObject
    {
        public static IWebElementAdapter UserCreate
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("td#content button[name='create']")); }
        }
    }
}