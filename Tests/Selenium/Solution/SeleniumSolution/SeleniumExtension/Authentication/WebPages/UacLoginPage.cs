using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension.Selenium.WebElements;

namespace SIX.SCS.QA.Selenium.Extension.Authentication.WebPages
{
    public class UacLoginPage : WebObject, IUacLoginPage
    {
        public string UserName
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_tbxUsername"))
                         .TextBox()
                         .TypeText(value);
            }
        }

        public string UserPasswort
        {
            set
            {
                // DB:       CryptedPassword=0x5F06F9D51AA05BFB6B6F7AF49AD9464427C9733A
                WebDriver.FindAdaptedElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_tbxPassword"))
                         .Password().TypeText(value);
            }
        }

        public IWebElement LoginButton
        {
            get { return WebDriver.FindElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_btnLogin")); }
        }
    }
}