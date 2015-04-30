using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Six.Test.Selenium.WebDriver;
using Six.Test.Selenium.WebDriver.WebElements;

namespace Six.Saferpay.Backoffice.Test.Pages.Common
{
    public class MetaNavBar : WebObject
    {
        // [FindsBy(How = How.CssSelector, Using = "li#text_logout a")] public static IWebElement LogOff;
        [FindsBy(How = How.CssSelector, Using = "ul#metalinks li a[href$='/BO/?lang=en']")]
        public IWebElement English;

        [FindsBy(How = How.CssSelector, Using = "ul#metalinks li a[href$='/BO/?lang=fr']")]
        public IWebElement French;

        [FindsBy(How = How.CssSelector, Using = "ul#metalinks li a[href$='/BO/?lang=de']")]
        public IWebElement German;

        [FindsBy(How = How.CssSelector, Using = "ul#metalinks li a[href$='/BO/?lang=it']")]
        public IWebElement Italian;

        [FindsBy(How = How.CssSelector, Using = "ul#metalinks li a[href$='/BO/?lang=pl']")]
        public IWebElement Polish;

        public MetaNavBar()
        {
            PageFactory.InitElements(TestDirector.WebDriver, this);
        }

        public static IWebElementAdapter LogOff
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("li#text_logout a")); }
        }
    }
}