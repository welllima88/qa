using OpenQA.Selenium;
using Six.Test.Selenium.Authentication.Webpages;
using Six.Test.Selenium.WebDriver.WebElements;

namespace Six.Saferpay.Backoffice.Test.Pages.Common
{
    public class UacLogOnPage : WebObject, IUacLogOnPage
    {
        public string UserName
        {
            set
            {
                WebDriver.FindAdaptedElement(By.Id("Username"))
                    .TextField()
                    .TypeText(value);
            }
        }

        public string UserPasswort
        {
            set
            {
                WebDriver.FindAdaptedElement(By.Id("Password"))
                    .PasswordTextField()
                    .TypeText(value);
            }
        }

        public void Login()
        {
            WebDriver.FindAdaptedElement(By.CssSelector("button[type='submit']")).Click();
        }
    }
}