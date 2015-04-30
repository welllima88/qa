using OpenQA.Selenium;
using Six.Test.Selenium.Authentication.Webpages;
using Six.Test.Selenium.WebDriver.WebElements;

namespace Six.Scs.Test.View.Common
{
    public class UacLogOnPageOld : WebObject, IUacLogOnPage
    {
        public string UserName
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("input.loginInput[name='spUsername']"))
                    .TextField()
                    .TypeText(value);
            }
        }

        public string UserPasswort
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("input.loginInput[name='spPassword']"))
                    .PasswordTextField()
                    .TypeText(value);
            }
        }

        public void Login()
        {
            WebDriver.FindAdaptedElement(By.CssSelector("input[alt='Login']")).Click();
        }
    }
}