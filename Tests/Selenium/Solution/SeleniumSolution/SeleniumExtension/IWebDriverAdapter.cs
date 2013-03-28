using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using OpenQA.Selenium;

namespace SIX.SCS.QA.Selenium.Extension
{
    public interface IWebDriverAdapter : IWebDriver
    {
        ReadOnlyCollection<IWebElementAdapter> FindAdaptedElements(By by);
        //todo modify to string and use CSS-Locator as default
        IWebElementAdapter FindAdaptedElement(By by);
        List<String> WebElementsAsStringList(ReadOnlyCollection<IWebElement> webElements);
        ISuggesterWebElement FindSuggesterElement(By by);
        IWebElement WaitForElementPresent(By locator);
        IWebElement WaitForElementPresent(By locator, int timeout);
    }
}