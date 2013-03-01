using System;
using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Extension.TestObjects;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Brand
{
    public class ContractSelect : WebObject
    {
        public ContractSelect(IWebDriverAdapter driver) : base(driver)
        {
        }

        public void SelectContract(String acq, String brand)
        {
            Driver.FindElement(By.XPath("//td[text()=\"" + acq + "\"]")).Click();
            Driver.FindElement(By.XPath("//td[text()=\" " + brand + "\"]")).Click();
        }

        public void ConfirmContractSelection()
        {
            Driver.FindElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_btnEditDetails")).Click();
        }
    }
}