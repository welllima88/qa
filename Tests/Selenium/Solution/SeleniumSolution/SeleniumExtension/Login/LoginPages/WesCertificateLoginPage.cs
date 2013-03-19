using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension.TestObjects;

namespace SIX.SCS.QA.Selenium.Extension.Login.LoginPages
{
    public class WesCertificateLoginPage:WebObject
    {
        public WesCertificateLoginPage(IWebDriverAdapter driver):base(driver)
        {            
        }

        public IWebElement LoginButton
        {
            get { return Driver.FindElement(By.CssSelector("form[name='LoginForm'] input.inputbutton[value='Login']")); }
        }

        public IWebElement HeadLine
        {
            get { return Driver.FindElement(By.CssSelector("div.divmainheadlineinner")); }
        }

        public IWebElement Continue
        {
            get { return Driver.FindElement(By.CssSelector("form[name='LoginForm'] input.inputbutton[value='Weiter']")); }
        }

        public IWebElement MessageInfo
        {
            get { return Driver.FindElement(By.CssSelector("form[name='LoginForm'] div#divmsginfo")); }
        }

        public IWebElement InputLabel
        {
            get { return Driver.FindElement(By.CssSelector("form[name='LoginForm'] div#divinputlabel")); }
        }


        public IWebElement Mandant(string mandant)
        {
            return
                Driver.FindElement(
                    By.CssSelector("form[name='LoginForm'] input[type='radio'][name='client'][value='" + mandant + "']"));
        }
    }
}