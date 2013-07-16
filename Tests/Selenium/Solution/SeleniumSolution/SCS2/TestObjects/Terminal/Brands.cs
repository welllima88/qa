using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Brand;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Terminal
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