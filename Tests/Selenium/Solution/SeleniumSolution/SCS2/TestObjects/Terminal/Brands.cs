using OpenQA.Selenium;
using SIX.SCS.QA.SCSPlatin.Tests.Selenium.TestObjects.Brand;
using SIX.SCS.QA.Selenium.Extension;

namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium.TestObjects.Terminal
{
    public class Brands : WebObject
    {
        public ContractView ContractView;

        public Brands()
        {
            ContractView = new ContractView();
        }

        public IWebElement BrandsDataTab
        {
            get
            {
                return
                    WebDriver.FindElement(
                        By.PartialLinkText(
                            "span#ctl00_bodyContentPlaceHolder_tbcTerminalData td.tab[textContent='Brands']"));
            }
        }
    }
}