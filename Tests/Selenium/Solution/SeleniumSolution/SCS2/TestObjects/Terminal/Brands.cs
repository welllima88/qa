using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Brand;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Terminal
{
    public class Brands : WebObject
    {
        public ContractView ContractView;

        public Brands(IWebDriverAdapter driver) : base(driver)
        {
            ContractView = new ContractView(Driver);
        }

        public IWebElement BrandsDataTab
        {
            get
            {
                return
                    Driver.FindElement(
                        By.PartialLinkText(
                            "span#ctl00_bodyContentPlaceHolder_tbcTerminalData td.tab[textContent='Brands']"));
            }
        }
    }
}