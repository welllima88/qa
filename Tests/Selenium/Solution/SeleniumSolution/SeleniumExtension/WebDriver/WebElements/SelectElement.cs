using OpenQA.Selenium;

namespace Six.Scs.QA.Selenium.Extension.WebDriver.WebElements
{
    public class SelectElement
    {
        private readonly IWebElement _webElement;

        public SelectElement(IWebElement webElement)
        {
            _webElement = webElement;
        }

        public string SelectedOption { get; private set; }

        public void SelectByValue(string value)
        {
            throw new System.NotImplementedException();
        }

        public void SelectByText(string text)
        {
            throw new System.NotImplementedException();
        }
    }
}