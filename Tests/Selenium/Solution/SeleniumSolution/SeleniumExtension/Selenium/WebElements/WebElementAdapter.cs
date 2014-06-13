using System.Collections.ObjectModel;
using System.Drawing;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SIX.SCS.Tests.Selenium.Extension.Selenium.WebElements
{
    /// <summary>
    ///     This class adds selenium features which we often need in Zebra and used in common instead of selenium
    ///     theWebElement. This class extends
    /// </summary>
    public class WebElementAdapter : IWebElementAdapter
    {
        /// <summary>
        ///     provide the public member
        /// </summary>
        private readonly IWebElement _theWebElement;

        public WebElementAdapter(IWebElement webElement)
        {
            _theWebElement = webElement;
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
                return new SelectElement(this);
            }
            throw new NotSelectableElementException(TagName);
        }

        public TextAreaElement TextArea()
        {
            return new TextAreaElement(this);
        }

        public TextBoxElement TextBox()
        {
            return new TextBoxElement(this);
        }

        public PasswortTextBoxElement Password()
        {
            return new PasswortTextBoxElement(this);
        }

        public IWebElement FindElement(By by)
        {
            return _theWebElement.FindElement(by);
        }

        public ReadOnlyCollection<IWebElement> FindElements(By by)
        {
            return _theWebElement.FindElements(by);
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

        public void Click()
        {
            _theWebElement.Click();
        }

        public string GetAttribute(string attributeName)
        {
            return _theWebElement.GetAttribute(attributeName);
        }

        public string GetCssValue(string propertyName)
        {
            return _theWebElement.GetCssValue(propertyName);
        }

        public string TagName
        {
            get { return _theWebElement.TagName; }
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

        public Point Location
        {
            get { return _theWebElement.Location; }
        }

        public Size Size
        {
            get { return _theWebElement.Size; }
        }

        public bool Displayed
        {
            get { return _theWebElement.Displayed; }
        }

        public CheckBoxElement CheckBox()
        {
            return new CheckBoxElement(this);
        }
    }
}