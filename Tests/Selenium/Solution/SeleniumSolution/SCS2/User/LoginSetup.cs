using OpenQA.Selenium;
using Six.Scs.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.User
{
    public class LoginSetup : WebObject
    {
        public static IWebElementAdapter SaveButton
        {
            get { return WebDriver.FindAdaptedElement(By.Id("save")); }
        }

        public static void Set(string name, string permission)
        {
            WebDriver.FindAdaptedElement(By.CssSelector("table#NewLoginServices tr[id='" + name + "'] td select"))
                .Selector()
                .SelectByText(permission);
        }
    }
}