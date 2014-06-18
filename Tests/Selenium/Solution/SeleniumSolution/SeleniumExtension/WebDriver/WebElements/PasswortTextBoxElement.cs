using OpenQA.Selenium;

namespace Six.Scs.QA.Selenium.Extension.WebDriver.WebElements
{
    public class PasswortTextBoxElement : TextBoxElement
    {
        public PasswortTextBoxElement(IWebElement webElement) : base(webElement)
        {
        }

        protected override string Type()
        {
            return "password";
        }
    }
}