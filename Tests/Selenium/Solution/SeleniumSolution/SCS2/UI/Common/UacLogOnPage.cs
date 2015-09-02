using OpenQA.Selenium;
using Six.Test.Selenium.Authentication.Webpages;
using Six.Test.Selenium.WebDriver.WebElements;

namespace Six.Scs.Test.UI.Common
{
    public class UacLogOnPage : WebObject, IUacLogOnPage
    {
        public string UserName
        {
            set
            {
                WebDriver.FindAdaptedElement(By.Id("username"))
                    .TextField()
                    .TypeText(value);
            }
        }

        public string UserPasswort
        {
            set
            {
                // DB:       CryptedPassword=0x5F06F9D51AA05BFB6B6F7AF49AD9464427C9733A
                WebDriver.FindAdaptedElement(By.Id("password"))
                    .PasswordTextField()
                    .TypeText(value);
            }
        }

        public void Login()
        {
            WebDriver.FindAdaptedElement(By.Id("login")).Click();
        }
    }
}