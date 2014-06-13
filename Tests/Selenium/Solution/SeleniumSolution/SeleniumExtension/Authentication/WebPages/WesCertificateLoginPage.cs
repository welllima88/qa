using OpenQA.Selenium;
using SIX.SCS.Tests.Selenium.Extension.Selenium.WebElements;

namespace SIX.SCS.Tests.Selenium.Extension.Authentication.WebPages
{
    public class WesCertificateLoginPage : WebObject
    {
        public IWebElement LoginButton
        {
            get
            {
                return WebDriver.FindElement(By.CssSelector("form[name='LoginForm'] input.inputbutton[value='Login']"));
            }
        }

        public IWebElement HeadLine
        {
            get { return WebDriver.FindElement(By.CssSelector("div.divmainheadlineinner")); }
        }

        public IWebElement Continue
        {
            get
            {
                return WebDriver.FindElement(By.CssSelector("form[name='LoginForm'] input.inputbutton[value='Weiter']"));
            }
        }

        public IWebElement MessageInfo
        {
            get { return WebDriver.FindElement(By.CssSelector("form[name='LoginForm'] div#divmsginfo")); }
        }

        public IWebElement InputLabel
        {
            get { return WebDriver.FindElement(By.CssSelector("form[name='LoginForm'] div#divinputlabel")); }
        }

        public IWebElement Mandant(string mandant)
        {
            return
                WebDriver.FindElement(
                    By.CssSelector("form[name='LoginForm'] input[type='radio'][name='client'][value='" + mandant + "']"));
        }
    }
}