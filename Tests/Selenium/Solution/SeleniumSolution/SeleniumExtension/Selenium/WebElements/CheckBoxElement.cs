using OpenQA.Selenium;

namespace SIX.SCS.Tests.Selenium.Extension.Selenium.WebElements
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
        ///     ensures and sets the the value for a checkbox if necessary
        /// </summary>
        /// <param name="userInput"></param>
        public void Set(bool userInput)
        {
            if (_webElement.Selected ^ userInput) //if antivalent..
            {
                _webElement.Click(); //..make equivalent
            }
        }

        public bool IsChecked()
        {
            return _webElement.Selected;
        }
    }
}