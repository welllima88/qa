using OpenQA.Selenium;
using Six.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.QA.Selenium.Extension.Authentication.Webpages
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