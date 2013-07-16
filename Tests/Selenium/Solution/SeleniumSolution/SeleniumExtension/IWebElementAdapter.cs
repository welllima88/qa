﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SIX.SCS.QA.Selenium.Extension
{
    /// <summary>
    ///     Defines the additional methods that are necessary for a common WebElement
    /// </summary>
    public interface IWebElementAdapter : IWebElement
    {
        void TypeText(string userInput);
        void SetCheckbox(bool userInput);
        SelectElement Selector();
    }
}