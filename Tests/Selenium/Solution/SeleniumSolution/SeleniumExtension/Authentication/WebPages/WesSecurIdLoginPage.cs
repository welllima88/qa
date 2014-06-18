using OpenQA.Selenium;
using Six.Scs.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.Extension.Authentication.WebPages
{
    public class WesSecurIdLoginPage : WebObject
    {
        public static IWebElement LoginButton
        {
            get
            {
                return WebDriver.FindElement(By.CssSelector("form[name='LoginForm'] input.inputbutton[value='Login']"));
            }
        }

        public static IWebElement HeadLine
        {
            get { return WebDriver.FindElement(By.CssSelector("div.divmainheadlineinner")); }
        }

        public static IWebElement Continue
        {
            get
            {
                return WebDriver.FindElement(By.CssSelector("form[name='LoginForm'] input.inputbutton[value='Weiter']"));
            }
        }

        public static  IWebElement MessageInfo
        {
            get { return WebDriver.FindElement(By.CssSelector("form[name='LoginForm'] div#divmsginfo")); }
        }

        public static IWebElement InputLabel
        {
            get { return WebDriver.FindElement(By.CssSelector("form[name='LoginForm'] div#divinputlabel")); }
        }

        public static string Mandant
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("form[name='LoginForm'] input[name='client']"))
                    .TextBox().TypeText(value);
            }
        }

        public static string User
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("form[name='LoginForm'] input[name='isiwebuserid']"))
                    .TextBox()
                    .TypeText(value);
            }
        }

        public static string Password
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("form[name='LoginForm'] input[name='isiwebpasswd']"))
                    .TextBox()
                    .TypeText(value);
            }
        }

        public static IWebElement ConfirmButton
        {
            get
            {
                return WebDriver.FindElement(By.CssSelector("form[name='LoginForm'] input.inputbutton[value='Senden']"));
            }
        }

        public static string SecurId
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("form[name='LoginForm'] input[name='isiwebpasswdInput']"))
                    .TextBox()
                    .TypeText(value);
            }
        }

        public static IWebElement LogoutLabel
        {
            get { return WebDriver.FindElement(By.CssSelector("#divinputlabel")); }
        }

        public static IWebElement LogoutMessage
        {
            get { return WebDriver.FindElement(By.CssSelector("#divmsginfo")); }
        }

        public static IWebElement LogoutHeader
        {
            get { return WebDriver.FindElement(By.CssSelector("div.divmainheadlineinner")); }
        }
    }
}