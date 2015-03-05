using OpenQA.Selenium;

namespace Six.QA.Selenium.Extension.WebDriver.WebElements
{
    public class TextFieldElement
    {
        private readonly IWebElement _webElement;

        public TextFieldElement(IWebElement webElement)
        {
            if (!(webElement.TagName.Equals("input") && webElement.GetAttribute("type").Equals(Type())))
                throw new NotTextBoxElementException(webElement.TagName, webElement.GetAttribute("type"));
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
        ///     Types in the given string into the textfield by first clearing it.
        /// </summary>
        /// <param name="userInput"></param>
        public void TypeText(string userInput)
        {
            _webElement.Clear();
            _webElement.SendKeys(userInput);
        }

        /// <summary>
        ///     Reads the text from the text-field
        /// </summary>
        /// <returns>the string value from the text-field</returns>
        public string Text()
        {
            return _webElement.GetAttribute("value");
        }

        /// <summary>
        ///     clears the text-field (useful for deleting predefined texts)
        /// </summary>
        public void Clear()
        {
            _webElement.Clear();
        }
    }
}