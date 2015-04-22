using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Six.Saferpay.QA.Selenium.Pages.Menu
{
    public class MySaferpay
    {
        [FindsBy(How = How.CssSelector, Using = "div#menu li a[href$='/Administration/Account']")]
        public IWebElement
            Administration;

        [FindsBy(How = How.CssSelector, Using = "div#menu li a[href$='/FileImport/FileList']")]
        public IWebElement
            BatchProcessing;

        [FindsBy(How = How.CssSelector, Using = "div#menu li a[href*='/user/Support.asp?CSRFToken=']")]
        public
            IWebElement
            OnlineSupport;

        [FindsBy(How = How.CssSelector, Using = "div#menu li a[href$='/Risk/Overview']")]
        public IWebElement RiskManagement;

        [FindsBy(How = How.CssSelector, Using = "div#menu li a[href$='/SecureCard/Overview']")]
        public IWebElement
            SecureCardData;

        [FindsBy(How = How.CssSelector,
            Using = "div#menu li a[href*='/SecurePayGate/iOffering.aspx?ServiceId=37&CSRFToken=']")]
        public IWebElement
            SecurePayGate;

        [FindsBy(How = How.CssSelector, Using = "div#menu li a[href$='/Commerce/JournalOverview']")]
        public IWebElement
            Transactions;
    }
}