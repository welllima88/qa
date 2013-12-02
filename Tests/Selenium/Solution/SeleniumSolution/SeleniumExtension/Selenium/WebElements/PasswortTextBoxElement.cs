using OpenQA.Selenium;

namespace SIX.SCS.QA.Selenium.Extension.Selenium.WebElements
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