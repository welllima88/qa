using System;
using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Brand
{
    public class ContractSelect : WebObject
    {
        public void SelectContract(String acq, String brand)
        {
            WebDriver.FindElement(By.XPath("//td[text()=\"" + acq + "\"]")).Click();
            WebDriver.FindElement(By.XPath("//td[text()=\" " + brand + "\"]")).Click();
        }

        public void ConfirmContractSelection()
        {
            WebDriver.FindElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_btnEditDetails")).Click();
        }
    }
}