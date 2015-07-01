namespace Six.Test.Selenium.WebDriver.WebElements
{
    /// <summary>
    ///     Defines the additional methods that are necessary for a common WebElement
    /// </summary>
    public interface IWebElement
    {
        string Text { get; }
        bool Selected { get; }
        bool Displayed { get; }
        bool Enabled { get; }
        CheckBoxElement CheckBox();
        SelectElement Selector();
        TextFieldElement TextField();
        PasswortTextFieldElement PasswordTextField();
        TextAreaElement TextArea();
        ButtonElement Button();
        void Click();
    }
}