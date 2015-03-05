using OpenQA.Selenium;
using Six.QA.Selenium.Extension.Authentication.Webpages;
using Six.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Saferpay.QA.Selenium.Views.Common
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
                // DB:       CryptedPassword=0x5F06F9D51AA05BFB6B6F7AF49AD9464427C9733A
                WebDriver.FindAdaptedElement(By.Id("Password"))
                    .PasswordTextField()
                    .TypeText(value);
            }
        }

        public void Login()
        {
            WebDriver.FindAdaptedElement(By.CssSelector("input.button[type='submit']")).Click();
        }
    }
}