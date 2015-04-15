using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Six.QA.Selenium.Extension.WebDriver;

namespace Six.Saferpay.QA.Selenium.Pages.Menu
{
    public class Menu
    {
        [FindsBy(How = How.CssSelector, Using = "div#menu li a[href$='/Administration/Account']")]
        public IWebElement
            Administration;

        [FindsBy(How = How.CssSelector, Using = "div#menu li a[href$='/FileImport/FileList']")]
        public IWebElement
            BatchProcessing;

        [FindsBy(How = How.CssSelector, Using = "div#menu li a[href$='/BO/ChangeEmailAddress']")]
        public IWebElement
            ChangeEmail;

        [FindsBy(How = How.CssSelector, Using = "div#menu li a[href$='/BO/ChangePassword']")]
        public IWebElement
            ChangePassword;

        [FindsBy(How = How.CssSelector, Using = "div#menu li a[href*='/user/Support.asp?CSRFToken=']")]
        public
            IWebElement
            OnlineSupport;

        [FindsBy(How = How.CssSelector,
            Using = "div#menu li a[href='https://www.six-payment-services.com/de/shared/offering/products/psp.html']")]
        public IWebElement ProductInfo;

        [FindsBy(How = How.CssSelector, Using = "div#menu li a[href$='/Risk/Overview']")]
        public IWebElement RiskManagement;

        [FindsBy(How = How.CssSelector, Using = "div#menu li a[href$='/SecureCard/Overview']")]
        public IWebElement
            SecureCardData;

        [FindsBy(How = How.CssSelector,
            Using = "div#menu li a[href*='/SecurePayGate/iOffering.aspx?ServiceId=37&CSRFToken=']")]
        public IWebElement
            SecurePayGate;

        [FindsBy(How = How.CssSelector, Using = "div#menu li a[href='https://gate.telekurs.ch/pmsp/?login']")]
        public
            IWebElement TopasPms;

        [FindsBy(How = How.CssSelector, Using = "div#menu li a[href$='/Commerce/JournalOverview']")]
        public IWebElement
            Transactions;

        public Menu()
        {
            PageFactory.InitElements(TestDirector.WebDriver, this);
        }
    }
}