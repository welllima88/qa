using OpenQA.Selenium;
using Six.Test.Selenium.WebDriver.WebElements;
using IWebElement = Six.Test.Selenium.WebDriver.WebElements.IWebElement;

namespace Six.Scs.Test.View.Common.Menu
{
    public class UserMenu : WebObject
    {
        public static IWebElement User
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("a[href*='/User/Index?USERNAME=']")); }
        }

        public static IWebElement New
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("a[href*='/User/New/?CUSTOMERID=']")); }
        }

        public static IWebElement Edit
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("a[href*='/User/Edit?USERNAME=']")); }
        }

        public static IWebElement Feedback
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("a[href*='/Feedback/List?USERNAME=']")); }
        }

        public static IWebElement Service
        {
            get
            {
                return WebDriver.FindAdaptedElement(By.CssSelector("a[href*='/User/SetupLoginService/?USERNAME=']"));
            }
        }

        public static IWebElement Roles
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("a[href*='/User/UserRoleEdit?USERNAME=']")); }
        }

        public static IWebElement ResetPassword
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("a[href*='/User/ResetPassword/?USERNAME=']")); }
        }
    }
}