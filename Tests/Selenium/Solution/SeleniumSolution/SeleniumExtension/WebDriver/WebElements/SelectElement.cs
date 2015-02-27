using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;

namespace Six.QA.Selenium.Extension.WebDriver.WebElements
{
    public class SelectElement
    {
        private readonly OpenQA.Selenium.Support.UI.SelectElement _webElement;

        public SelectElement(IWebElement webElement)
        {
            _webElement = new OpenQA.Selenium.Support.UI.SelectElement(webElement);
        }

        public string SelectedOption
        {
            get { return _webElement.SelectedOption.Text; }
        }

        public IEnumerable<string> Options
        {
            get { return _webElement.Options.Select(s => s.Text); }
        }

        public void SelectByValue(string value)
        {
            _webElement.SelectByValue(value);
        }

        public void SelectByText(string text)
        {
            _webElement.SelectByText(text);
        }
    }
}