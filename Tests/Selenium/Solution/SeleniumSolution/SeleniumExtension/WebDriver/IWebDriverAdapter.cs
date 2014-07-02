using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using OpenQA.Selenium;
using Six.Scs.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.Extension.WebDriver
{
    public interface IWebDriverAdapter : IWebDriver
    {
        ReadOnlyCollection<IWebElementAdapter> FindAdaptedElements(By by);
        IWebElementAdapter FindAdaptedElement(By by);
        List<String> WebElementsAsStringList(IEnumerable<IWebElement> webElements);
    }
}