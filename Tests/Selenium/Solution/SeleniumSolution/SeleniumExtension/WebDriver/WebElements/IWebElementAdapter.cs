using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Six.Scs.QA.Selenium.Extension.WebDriver.WebElements
{
    /// <summary>
    ///     Defines the additional methods that are necessary for a common WebElement
    /// </summary>
    public interface IWebElementAdapter : IWebElement
    {
        CheckBoxElement CheckBox();
        SelectElement Selector();
        TextField TextBox();
        PasswortTextField Password();
        TextArea TextArea();
    }
}