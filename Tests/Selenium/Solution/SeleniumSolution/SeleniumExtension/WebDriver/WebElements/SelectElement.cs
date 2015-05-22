using System;
using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;

namespace Six.Test.Selenium.WebDriver.WebElements
{
    public class SelectElement
    {
        private readonly OpenQA.Selenium.Support.UI.SelectElement _webElement;

        public SelectElement(IWebElement webElement)
        {
            _webElement = new OpenQA.Selenium.Support.UI.SelectElement(webElement);
        }

        /// <summary>
        ///     returns the text of the selected option
        /// </summary>
        public string SelectedOption
        {
            get { return _webElement.SelectedOption.Text; }
        }

        /// <summary>
        ///     returns the texts of all possible options
        /// </summary>
        public IEnumerable<string> Options
        {
            get { return _webElement.Options.Select(s => s.Text); }
        }

        /// <summary>
        ///     Selects an option with the given value, which is usually not visible to the user
        /// </summary>
        /// <param name="value">the (internal) value of a select option</param>
        public void SelectByValue(string value)
        {
            _webElement.SelectByValue(value);
        }

        /// <summary>
        ///     Selects an option with the given text, which is usually visible to the user
        /// </summary>
        /// <param name="text">the text of a select option</param>
        public void SelectByText(string text)
        {
            try
            {
                _webElement.SelectByText(text);
            }
            catch (Exception)
            {
                Console.Out.WriteLine("Select tolerant way: contains {0} for {1}", text, _webElement);
                _webElement.Options.FirstOrDefault(o => o.Text.Contains(text)).Click();
            }
        }
    }
}