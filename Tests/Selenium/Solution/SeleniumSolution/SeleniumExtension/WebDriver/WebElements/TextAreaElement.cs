using OpenQA.Selenium;

namespace Six.Scs.QA.Selenium.Extension.WebDriver.WebElements
{
    public class TextAreaElement
    {
        private readonly IWebElement _webElement;

        public TextAreaElement(IWebElement webElement)
        {
            if (!(webElement.TagName.Equals("textarea")))
                throw new NotTextAreaElementException(webElement.TagName);
            _webElement = webElement;
        }

        /// <summary>
        ///     This method needs to be implemented for different input text boxes
        /// </summary>
        /// <returns>the return string is the input type attribute</returns>
        protected virtual string Type()
        {
            return "text";
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