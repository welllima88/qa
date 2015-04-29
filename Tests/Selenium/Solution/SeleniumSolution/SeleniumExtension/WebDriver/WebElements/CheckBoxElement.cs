using OpenQA.Selenium;

namespace Six.Test.Selenium.WebDriver.WebElements
{
    public class CheckBoxElement
    {
        private readonly IWebElement _webElement;

        public CheckBoxElement(IWebElement webElement)
        {
            if (!(webElement.TagName.Equals("input") && webElement.GetAttribute("type").Equals("checkbox")))
                throw new NotCheckableElementException(webElement.TagName, webElement.GetCssValue("type"));
            _webElement = webElement;
        }

        /// <summary>
        ///     ensures the de-/activation for a checkbox given to the value and clicks the element (only) if necessary
        /// </summary>
        /// <param name="userInput"></param>
        public void Set(bool userInput)
        {
            if (_webElement.Selected ^ userInput) //if antivalent..
            {
                _webElement.Click(); //..make equivalent
            }
        }

        /// <summary>
        ///     Returns whether an (input) element is selected or not this
        /// </summary>
        /// <returns>true if the element is selected, else false</returns>
        public bool IsChecked()
        {
            return _webElement.Selected;
        }
    }
}