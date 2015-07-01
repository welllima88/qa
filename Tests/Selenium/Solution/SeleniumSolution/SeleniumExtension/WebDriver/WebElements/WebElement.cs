using OpenQA.Selenium;

namespace Six.Test.Selenium.WebDriver.WebElements
{
    /// <summary>
    ///     This class wraps WebElements from selenium and adds features which are commonly needed.
    /// </summary>
    public class WebElement : IWebElement
    {
        /// <summary>
        ///     provide the public member
        /// </summary>
        protected readonly OpenQA.Selenium.IWebElement _theWebElement;

        public WebElement(OpenQA.Selenium.IWebElement webElement)
        {
            _theWebElement = webElement;
        }

        /// <summary>
        ///     Gets the tag name of this element.
        /// </summary>
        public string TagName
        {
            get { return _theWebElement.TagName; }
        }

        /// <summary>
        ///     Adds method for drop down lists it returns a new reference of a 'SelectElement' on which different selects (by
        ///     value, name etc.)
        ///     can be executed
        /// </summary>
        /// <returns>SelectElement for the actual WebElement</returns>
        public SelectElement Selector()
        {
            if (TagName.Equals("select"))
            {
                return new SelectElement(_theWebElement);
            }
            throw new NotSelectableElementException(TagName);
        }

        public TextAreaElement TextArea()
        {
            return new TextAreaElement(_theWebElement);
        }

        public TextFieldElement TextField()
        {
            return new TextFieldElement(_theWebElement);
        }

        public PasswortTextFieldElement PasswordTextField()
        {
            return new PasswortTextFieldElement(_theWebElement);
        }

        public void Click()
        {
            _theWebElement.Click();
        }

        public string Text
        {
            get { return _theWebElement.Text; }
        }

        public bool Enabled
        {
            get { return _theWebElement.Enabled; }
        }

        public bool Selected
        {
            get { return _theWebElement.Selected; }
        }

        public bool Displayed
        {
            get { return _theWebElement.Displayed; }
        }

        public CheckBoxElement CheckBox()
        {
            return new CheckBoxElement(_theWebElement);
        }

        public ButtonElement Button()
        {
            return new ButtonElement(_theWebElement);
        }

        public void Clear()
        {
            _theWebElement.Clear();
        }

        public void SendKeys(string text)
        {
            _theWebElement.SendKeys(text);
        }

        public void Submit()
        {
            _theWebElement.Submit();
        }

        public string GetAttribute(string attributeName)
        {
            return _theWebElement.GetAttribute(attributeName);
        }

        public string GetCssValue(string propertyName)
        {
            return _theWebElement.GetCssValue(propertyName);
        }
    }
}