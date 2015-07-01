using OpenQA.Selenium;

namespace Six.Test.Selenium.WebDriver.WebElements
{
    public class TextFieldElement
    {
        protected OpenQA.Selenium.IWebElement WebElement;

        /// <summary>
        ///     provides the constructor for derived classes which need to skip the check of the base clase and use its own init
        /// </summary>
        protected TextFieldElement()
        {
        }

        public TextFieldElement(OpenQA.Selenium.IWebElement webElement)
        {
            if (!(webElement.TagName.Equals("input") && webElement.GetAttribute("type").Equals(Type())))
                throw new NotTextBoxElementException(webElement.TagName, webElement.GetAttribute("type"));
            WebElement = webElement;
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
            WebElement.Clear();
            WebElement.SendKeys(userInput);
        }

        /// <summary>
        ///     Reads the text from the text-field
        /// </summary>
        /// <returns>the string value from the text-field</returns>
        public string Text()
        {
            return WebElement.GetAttribute("value");
        }

        /// <summary>
        ///     clears the text-field (useful for deleting predefined texts)
        /// </summary>
        public void Clear()
        {
            WebElement.Clear();
        }
    }
}