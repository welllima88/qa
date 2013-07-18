using OpenQA.Selenium;

namespace SIX.SCS.QA.Selenium.Tests.SCSClassics.TestObjects.Menu
{
    public class MassMutationMenu
    {
        private readonly IWebDriver _driver;

        public MassMutationMenu(IWebDriver driver)
        {
            _driver = driver;
        }

        public IWebElement CustomerCreate
        {
            get { return _driver.FindElement(By.CssSelector("a[href*='/MassMutation/CustomersFileUpload.aspx']")); }
        }

        public IWebElement LocationCreate
        {
            get { return _driver.FindElement(By.CssSelector("a[href*='/MassMutation/LocationsFileUpload.aspx']")); }
        }

        public IWebElement TerminalCreate
        {
            get { return _driver.FindElement(By.CssSelector("a[href*='/MassMutation/TerminalsFileUpload.aspx']")); }
        }

        public IWebElement ContractCreate
        {
            get { return _driver.FindElement(By.CssSelector("a[href*='/MassMutation/ContractsFileUpload.aspx']")); }
        }

        public IWebElement BusinessTemplateMigrate
        {
            get { return _driver.FindElement(By.CssSelector("a[href*='/MassMutation/BTMigrationFileUpload.aspx']")); }
        }
    }
}