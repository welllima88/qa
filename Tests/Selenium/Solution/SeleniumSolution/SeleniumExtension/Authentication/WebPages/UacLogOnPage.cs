using OpenQA.Selenium;
using Six.Scs.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.Extension.Authentication.Webpages
{
    public class UacLogOnPage : WebObject, IUacLogOnPage
    {
        public string UserName
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_tbxUsername"))
                    .TextField()
                    .TypeText(value);
            }
        }

        public string UserPasswort
        {
            set
            {
                // DB:       CryptedPassword=0x5F06F9D51AA05BFB6B6F7AF49AD9464427C9733A
                WebDriver.FindAdaptedElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_tbxPassword"))
                    .PasswordTextField().TypeText(value);
            }
        }

        public IWebElementAdapter LoginButton
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_btnLogin")); }
        }
    }
}