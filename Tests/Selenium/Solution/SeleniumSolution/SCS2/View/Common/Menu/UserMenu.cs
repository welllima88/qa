using OpenQA.Selenium;
using Six.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Application.View.Common.Menu
{
    public class UserMenu : WebObject
    {
        public static IWebElementAdapter User
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("a[href*='/User/Index?USERNAME=']")); }
        }

        public static IWebElementAdapter New
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("a[href*='/User/New/?CUSTOMERID=']")); }
        }

        public static IWebElementAdapter Edit
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("a[href*='/User/Edit?USERNAME=']")); }
        }

        public static IWebElementAdapter Feedback
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("a[href*='/Feedback/List?USERNAME=']")); }
        }

        public static IWebElementAdapter Service
        {
            get
            {
                return WebDriver.FindAdaptedElement(By.CssSelector("a[href*='/User/SetupLoginService/?USERNAME=']"));
            }
        }

        public static IWebElementAdapter Roles
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("a[href*='/User/UserRoleEdit?USERNAME=']")); }
        }

        public static IWebElementAdapter ResetPassword
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("a[href*='/User/ResetPassword/?USERNAME=']")); }
        }
    }
}