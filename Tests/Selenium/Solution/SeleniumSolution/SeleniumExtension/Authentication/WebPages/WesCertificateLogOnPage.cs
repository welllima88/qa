using OpenQA.Selenium;
using Six.Test.Selenium.WebDriver.WebElements;
using IWebElement = Six.Test.Selenium.WebDriver.WebElements.IWebElement;

namespace Six.Test.Selenium.Authentication.Webpages
{
    public class WesCertificateLogOnPage : WebObject
    {
        public static IWebElement LoginButton
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(
                        By.CssSelector("form[name='LoginForm'] input.inputbutton[value='Login']"));
            }
        }

        public static IWebElement HeadLine
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("div.divmainheadlineinner")); }
        }

        public static IWebElement Continue
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(
                        By.CssSelector("form[name='LoginForm'] input.inputbutton[value='Weiter']"));
            }
        }

        public static IWebElement MessageInfo
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("form[name='LoginForm'] div#divmsginfo")); }
        }

        public static IWebElement InputLabel
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("form[name='LoginForm'] div#divinputlabel")); }
        }

        public static IWebElement Mandant(string mandant)
        {
            return
                WebDriver.FindAdaptedElement(
                    By.CssSelector("form[name='LoginForm'] input[type='radio'][name='client'][value='" + mandant + "']"));
        }
    }
}