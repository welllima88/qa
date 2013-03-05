using System;
using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Extension.TestObjects;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Brand
{
    public class ContractCreate : WebObject
//TODO contract create does not indicate precisely for which brand the properties should be set if multiple brand create executed
    {
        private ContractSelect _contractSelect;

        public ContractCreate(IWebDriverAdapter driver) : base(driver)
        {
            _contractSelect = new ContractSelect(Driver);
            //throw new NotImplementedException();
        }

        public void ClickBrandContractEdit(String brand)
        {
            ClickEditContract(brand, "contract");
        }

        public void ClickAcquirerContractEdit(String acquirer)
        {
            ClickEditContract(acquirer, "brand");
        }

        private void ClickEditContract(String brand, String brandType)
        {
            Driver.FindElement(
                By.CssSelector("div.title[textContent~=\"" + brand + "\"] input[src$=\"" + brandType + "_edit.gif\"]")).
                Click();
        }

        public void SelectMcc(String mcc)
        {
            Driver.FindAdaptedElement(
                By.CssSelector(
                    "#ctl00_bodyContentPlaceHolder_acquirerUserControl_acquirerUserControlPropertyCategoryCode_sugCategoryCode"))
                .Selector().SelectByText(mcc);
        }

        public void SetVpNo(String vpNo)
        {
            Driver.FindElement(
                By.CssSelector(
                    "#ctl00_bodyContentPlaceHolder_acquirerUserControl_acquirerUserControlPropertyContractNumber_valueText"))
                .Clear();
            Driver.FindElement(
                By.CssSelector(
                    "#ctl00_bodyContentPlaceHolder_acquirerUserControl_acquirerUserControlPropertyContractNumber_valueText"))
                .SendKeys(vpNo);
        }

        public void SelectBusinessTemplate(String businessTemplate)
        {
            Driver.FindAdaptedElement(
                By.CssSelector("#ctl00_bodyContentPlaceHolder_acquirerUserControl_ddBusinessTemplate")).Selector().
                SelectByText(businessTemplate);
        }

        public void SetDcc(bool dccEnabeled)
        {
            Driver.FindAdaptedElement(By.CssSelector("input[id$='PropertyDCCflag_cbxDCC']")).SetCheckbox(dccEnabeled);
        }

        public void SetDccBaseCurrency(String dccBaseCurrency)
        {
            Driver.FindElement(By.CssSelector("div[id*='PropertyDCCBaseCurrency'] div[value='" + dccBaseCurrency + "']"))
                .Click();
        }

        public void SaveAndCreate()
        {
            Driver.FindElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_lwpBrandsFinishButton")).Click();
        }
    }
}