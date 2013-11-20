using System;
using OpenQA.Selenium;

namespace SIX.SCS.QA.Selenium.Extension.TestObjects.Brand
{
    public class ContractCreate : WebObject
//TODO contract create does not indicate precisely for which brand the properties should be set if multiple brand create executed
    {
        private ContractSelect _contractSelect;

        public ContractCreate()
        {
            _contractSelect = new ContractSelect();
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
            WebDriver.FindElement(
                By.CssSelector("div.title[textContent~=\"" + brand + "\"] input[src$=\"" + brandType + "_edit.gif\"]")).
                      Click();
        }

        public void SelectMcc(String mcc)
        {
            WebDriver.FindAdaptedElement(
                By.CssSelector(
                    "#ctl00_bodyContentPlaceHolder_acquirerUserControl_acquirerUserControlPropertyCategoryCode_sugCategoryCode"))
                     .Selector().SelectByText(mcc);
        }

        public void SetVpNo(String vpNo)
        {
            WebDriver.FindAdaptedElement(
                By.CssSelector(
                    "#ctl00_bodyContentPlaceHolder_acquirerUserControl_acquirerUserControlPropertyContractNumber_valueText"))
                     .TypeText(vpNo);
        }

        public void SelectBusinessTemplate(String businessTemplate)
        {
            WebDriver.FindAdaptedElement(
                By.CssSelector("#ctl00_bodyContentPlaceHolder_acquirerUserControl_ddBusinessTemplate")).Selector().
                      SelectByText(businessTemplate);
        }

        public void SetDcc(bool dccEnabeled)
        {
            WebDriver.FindAdaptedElement(By.CssSelector("input[id$='PropertyDCCflag_cbxDCC']")).CheckBox().Set(dccEnabeled);
        }

        public void SetDccBaseCurrency(String dccBaseCurrency)
        {
            WebDriver.FindElement(
                By.CssSelector("div[id*='PropertyDCCBaseCurrency'] div[value='" + dccBaseCurrency + "']"))
                     .Click();
        }

        public void SaveAndCreate()
        {
            WebDriver.FindElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_lwpBrandsFinishButton")).Click();
        }
    }
}