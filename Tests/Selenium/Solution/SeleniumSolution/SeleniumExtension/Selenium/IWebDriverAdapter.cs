using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension.Selenium.WebElements;

namespace SIX.SCS.QA.Selenium.Extension.Selenium
{
    public interface IWebDriverAdapter : IWebDriver
    {
        ReadOnlyCollection<IWebElementAdapter> FindAdaptedElements(By by);
        //todo modify to string and use CSS-Locator as default
        IWebElementAdapter FindAdaptedElement(By by);
        List<String> WebElementsAsStringList(IEnumerable<IWebElement> webElements);
        ISuggesterWebElement FindSuggesterElement(By by);
        IWebElement WaitForElementPresent(By locator);
    }
}