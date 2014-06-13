using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SIX.SCS.Tests.Selenium.Extension.Selenium.WebElements
{
    /// <summary>
    ///     Defines the additional methods that are necessary for a common WebElement
    /// </summary>
    public interface IWebElementAdapter : IWebElement
    {
        CheckBoxElement CheckBox();
        SelectElement Selector();
        TextBoxElement TextBox();
        PasswortTextBoxElement Password();
        TextAreaElement TextArea();
    }
}