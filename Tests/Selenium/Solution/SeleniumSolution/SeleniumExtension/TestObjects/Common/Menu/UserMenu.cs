using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension.Selenium.WebElements;

namespace SIX.SCS.QA.Selenium.Extension.TestObjects.Common.Menu
{
    public class UserMenu : WebObject
    {
        public static IWebElement User
        {
            get { return WebDriver.FindElement(By.CssSelector("a[href*='/scs2/User/Index?USERNAME=']")); }
        }

        public static IWebElement New
        {
            get { return WebDriver.FindElement(By.CssSelector("a[href*='/User/New/?CUSTOMERID=']")); }
        }

        public static IWebElement Edit
        {
            get { return WebDriver.FindElement(By.CssSelector("a[href*='/User/Edit?USERNAME=']")); }
        }

        public static IWebElement Feedback
        {
            get { return WebDriver.FindElement(By.CssSelector("a[href*='/Feedback/List?USERNAME=']")); }
        }

        public static IWebElement Service
        {
            get { return WebDriver.FindElement(By.CssSelector("a[href*='/User/SetupLoginService/?USERNAME=']")); }
        }

        public static IWebElement Roles
        {
            get { return WebDriver.FindElement(By.CssSelector("a[href*='/User/UserRoleEdit?USERNAME=']")); }
        }

        public static IWebElement ResetPassword
        {
            get { return WebDriver.FindElement(By.CssSelector("a[href*='/User/ResetPassword/?USERNAME=']")); }
        }
    }
}