using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Six.Scs.QA.Selenium.Extension.WebDriver.WebElements
{
    /// <summary>
    ///     Defines the additional methods that are necessary for a common WebElement
    /// </summary>
    public interface IWebElementAdapter 
    {
        CheckBoxElement CheckBox();
        SelectElement Selector();
        TextFieldElement TextField();
        PasswortTextFieldElement PasswordTextField();
        TextAreaElement TextArea();
        ButtonElement Button();
        string Text { get; }
        bool Selected { get; }
        bool Displayed { get; }
        bool Enabled { get; }
        void Click();        
    }
}