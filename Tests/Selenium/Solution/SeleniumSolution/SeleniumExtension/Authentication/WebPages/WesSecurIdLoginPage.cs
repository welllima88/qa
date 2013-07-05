using OpenQA.Selenium;

namespace SIX.SCS.QA.Selenium.Extension.Authentication.WebPages
{
    public class WesSecurIdLoginPage : WebObject
    {
        public WesSecurIdLoginPage(IWebDriverAdapter driver) : base(driver)
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

        public string Mandant
        {
            set { Driver.FindAdaptedElement(By.CssSelector("form[name='LoginForm'] input[name='client']")).TypeText(value); }
        }

        public string User
        {
            set
            {
                Driver.FindAdaptedElement(By.CssSelector("form[name='LoginForm'] input[name='isiwebuserid']")).TypeText(
                    value);
            }
        }

        public string Password
        {
            set
            {
                Driver.FindAdaptedElement(By.CssSelector("form[name='LoginForm'] input[name='isiwebpasswd']")).TypeText(
                    value);
            }
        }

        public IWebElement ConfirmButton
        {
            get { return Driver.FindElement(By.CssSelector("form[name='LoginForm'] input.inputbutton[value='Senden']")); }
        }

        public string SecurId
        {
            set
            {
                Driver.FindAdaptedElement(By.CssSelector("form[name='LoginForm'] input[name='isiwebpasswdInput']")).
                    TypeText(value);
            }
        }

        public IWebElement LogoutLabel
        {
            get { return Driver.FindElement(By.CssSelector("#divinputlabel")); }
        }

        public IWebElement LogoutMessage
        {
            get { return Driver.FindElement(By.CssSelector("#divmsginfo")); }
        }

        public IWebElement LogoutHeader
        {
            get { return Driver.FindElement(By.CssSelector("div.divmainheadlineinner")); }
        }
    }
}