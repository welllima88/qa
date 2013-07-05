using OpenQA.Selenium;

namespace SIX.SCS.QA.Selenium.Extension.Authentication.WebPages
{
    public class UacLoginPage : WebObject
    {
        public UacLoginPage(IWebDriverAdapter driver) : base(driver)
        {
        }

        public string UserName
        {
            set { Driver.FindAdaptedElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_tbxUsername")).TypeText(value); }
        }

        public string UserPasswort
        {
            set
            {
                // DB:       CryptedPassword=0x5F06F9D51AA05BFB6B6F7AF49AD9464427C9733A
                Driver.FindAdaptedElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_tbxPassword")).TypeText(value);
            }
        }

        public IWebElement LoginButton
        {
            get { return Driver.FindElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_btnLogin")); }
        }
    }
}