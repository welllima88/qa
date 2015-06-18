using OpenQA.Selenium;
using Six.Test.Selenium.WebDriver.WebElements;

namespace Six.Scs.Test.View.Tickets.Process
{
    public class View : WebObject
    {
        private readonly string pre = "div[ng-if='terminalTicket.acquirerContract']";

        public static string Header
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("td#content div.panel-heading")).Text; }
        }

        public string ContractNumber
        {
            set { WebDriver.FindAdaptedElement(By.Id("contractNumber")).TextField().TypeText(value); }
        }

        public string DccProvider
        {
            set { WebDriver.FindAdaptedElement(By.Id("dccProvider")).Selector().SelectByText(value); }
        }

        public string CategoryCode
        {
            set { WebDriver.FindAdaptedElement(By.Id("categoryCode")).Selector().SelectByText(value); }
        }

        public string BusinessTemplate
        {
            set { WebDriver.FindAdaptedElement(By.Id("businessTemplate")).Selector().SelectByText(value); }
        }

        public string Brands
        {
            set { WebDriver.FindAdaptedElement(By.Id("ep2BrandContracts")).Selector().SelectByText(value); }
        }

        public void SaveAndClose()
        {
            WebDriver.FindAdaptedElement(By.CssSelector(pre + " button.btn-primary[type='submit']")).Click();
        }

        public void Delete()
        {
            WebDriver.FindAdaptedElement(By.CssSelector(pre + " button[ng-click='deleteContract()']")).Click();
        }
    }
}