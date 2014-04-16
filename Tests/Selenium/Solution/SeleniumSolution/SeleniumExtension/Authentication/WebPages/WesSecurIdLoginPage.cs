using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension.Selenium.WebElements;

namespace SIX.SCS.QA.Selenium.Extension.Authentication.WebPages
{
    public class WesSecurIdLoginPage : WebObject
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

        public string Mandant
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("form[name='LoginForm'] input[name='client']"))
                    .TextBox().TypeText(value);
            }
        }

        public string User
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("form[name='LoginForm'] input[name='isiwebuserid']"))
                    .TextBox()
                    .TypeText(value);
            }
        }

        public string Password
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("form[name='LoginForm'] input[name='isiwebpasswd']"))
                    .TextBox()
                    .TypeText(value);
            }
        }

        public IWebElement ConfirmButton
        {
            get
            {
                return WebDriver.FindElement(By.CssSelector("form[name='LoginForm'] input.inputbutton[value='Senden']"));
            }
        }

        public string SecurId
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("form[name='LoginForm'] input[name='isiwebpasswdInput']"))
                    .TextBox()
                    .TypeText(value);
            }
        }

        public IWebElement LogoutLabel
        {
            get { return WebDriver.FindElement(By.CssSelector("#divinputlabel")); }
        }

        public IWebElement LogoutMessage
        {
            get { return WebDriver.FindElement(By.CssSelector("#divmsginfo")); }
        }

        public IWebElement LogoutHeader
        {
            get { return WebDriver.FindElement(By.CssSelector("div.divmainheadlineinner")); }
        }
    }
}