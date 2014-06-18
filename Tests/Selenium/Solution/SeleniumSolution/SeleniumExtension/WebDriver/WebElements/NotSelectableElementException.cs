using System;

namespace Six.Scs.QA.Selenium.Extension.WebDriver.WebElements
{
    /// <summary>
    ///     This exception is thrown, if the Selector is not a select WebElement
    /// </summary>
    public class NotSelectableElementException : Exception
    {
        private readonly string _tagName;

        public NotSelectableElementException(string tagName)
        {
            _tagName = tagName;
        }

        public override string Message
        {
            get { return _tagName; }
        }
    }
}