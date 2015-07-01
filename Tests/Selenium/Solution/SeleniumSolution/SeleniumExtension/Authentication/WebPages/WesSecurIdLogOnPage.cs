using OpenQA.Selenium;
using Six.Test.Selenium.WebDriver.WebElements;
using IWebElement = Six.Test.Selenium.WebDriver.WebElements.IWebElement;

namespace Six.Test.Selenium.Authentication.Webpages
{
    public class WesSecurIdLogOnPage : WebObject
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

        public static string Mandant
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("form[name='LoginForm'] input[name='client']"))
                    .TextField().TypeText(value);
            }
        }

        public static string User
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("form[name='LoginForm'] input[name='isiwebuserid']"))
                    .TextField()
                    .TypeText(value);
            }
        }

        public static string Password
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("form[name='LoginForm'] input[name='isiwebpasswd']"))
                    .PasswordTextField()
                    .TypeText(value);
            }
        }

        public static IWebElement ConfirmButton
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(
                        By.CssSelector("form[name='LoginForm'] input.inputbutton[value='Senden']"));
            }
        }

        public static string SecurId
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("form[name='LoginForm'] input[name='isiwebpasswdInput']"))
                    .PasswordTextField()
                    .TypeText(value);
            }
        }

        public static IWebElement LogoutLabel
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("#divinputlabel")); }
        }

        public static IWebElement LogoutMessage
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("#divmsginfo")); }
        }

        public static IWebElement LogoutHeader
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("div.divmainheadlineinner")); }
        }
    }
}