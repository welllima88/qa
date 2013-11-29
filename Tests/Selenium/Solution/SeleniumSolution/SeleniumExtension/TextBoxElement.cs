using OpenQA.Selenium;

namespace SIX.SCS.QA.Selenium.Extension
{
    public class TextBoxElement
    {
        private readonly IWebElement _webElement;

        public TextBoxElement(IWebElement webElement)
        {
            if (!(webElement.TagName.Equals("input") && webElement.GetAttribute("type").Equals("text")))
                throw new NotTextBoxElementException(webElement.TagName, webElement.GetCssValue("type"));
            _webElement = webElement;
        }

        /// <summary>
        ///     ensures and sets the the value for a checkbox if necessary
        /// </summary>
        /// <param name="userInput"></param>
        public void TypeText(string userInput)
        {
            _webElement.Clear();
            _webElement.SendKeys(userInput);
        }

        public string Text()
        {
            return _webElement.GetAttribute("value");
        }

        public void Clear()
        {
            _webElement.Clear();
        }
    }
}