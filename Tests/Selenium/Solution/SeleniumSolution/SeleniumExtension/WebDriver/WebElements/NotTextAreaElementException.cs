using System;

namespace Six.Scs.QA.Selenium.Extension.WebDriver.WebElements
{
    public class NotTextAreaElementException : Exception
    {
        private readonly string _tagName;

        public NotTextAreaElementException(string tagName)
        {
            _tagName = tagName;
        }

        public override string Message
        {
            get { return _tagName; }
        }
    }
}