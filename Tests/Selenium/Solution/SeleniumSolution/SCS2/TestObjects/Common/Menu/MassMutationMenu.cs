using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Common.Menu
{
    public class MassMutationMenu : MenuObject
    {
        public MassMutationMenu(IWebDriverAdapter driver) : base(driver)
        {
        }


        public IWebElement CustomerCreate
        {
            get { return Driver.FindElement(By.CssSelector("a[href*='/MassMutation/CustomersFileUpload.aspx']")); }
        }

        public IWebElement LocationCreate
        {
            get { return Driver.FindElement(By.CssSelector("a[href*='/MassMutation/LocationsFileUpload.aspx']")); }
        }

        public IWebElement TerminalCreate
        {
            get { return Driver.FindElement(By.CssSelector("a[href*='/MassMutation/TerminalsFileUpload.aspx']")); }
        }

        public IWebElement ContractCreate
        {
            get { return Driver.FindElement(By.CssSelector("a[href*='/MassMutation/ContractsFileUpload.aspx']")); }
        }

        public IWebElement BusinessTemplateMigrate
        {
            get { return Driver.FindElement(By.CssSelector("a[href*='/MassMutation/BTMigrationFileUpload.aspx']")); }
        }
    }
}