using OpenQA.Selenium;

namespace SIX.SCS.QA.Selenium.Extension
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