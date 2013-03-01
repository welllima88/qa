using System;
using OpenQA.Selenium;

namespace SIX.SCS.QA.Selenium.Extension.TestObjects
{
    public abstract class WebObject : IWebObject
    {
        protected WebObject(IWebDriverAdapter driver)
        {
            Driver = driver;
        }
        //private WebObject()
        //{
        //   throw new NotSupportedException("The default constructor is not allowed to be used to avoid missing webdriver reference");
        //}

        public IWebDriverAdapter Driver { get; private set; }
    }
}