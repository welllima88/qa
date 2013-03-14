using System;
using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Extension.TestObjects;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Brand
{
    public class ContractEdit : WebObject
    {
        public ContractEdit(IWebDriverAdapter driver) : base(driver)
        {
        }

        /// <summary>
        /// Clicks edit on the desired brand
        /// </summary>
        /// <param name="brand">brand name e.g. "American Express [635]"</param>
        public void ClickBrandContractEdit(String brand)
        {
            ClickEditContract(brand, "contract");
        }

        /// <summary>
        /// /// Clicks edit on the desired acquirer
        /// </summary>
        /// <param name="acquirer">"Protokoll EP2 [281]" for SIX Payment Services (Multipay)</param>
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

        /// <summary>
        /// Sets the MCC (merchant category code)
        /// </summary>
        /// <param name="mcc">e.g. "5111: STATIONERY/OFF-SUPP/PRINTING"</param>
        public void SelectMcc(String mcc)
        {
            Driver.FindAdaptedElement(
                By.CssSelector(
                    "#ctl00_bodyContentPlaceHolder_acquirerUserControl_acquirerUserControlPropertyCategoryCode_sugCategoryCode"))
                .Selector().SelectByText(mcc);
        }

        public void SetVpNo(String vpNo)
        {
            Driver.FindAdaptedElement(
                By.CssSelector(
                    "#ctl00_bodyContentPlaceHolder_acquirerUserControl_acquirerUserControlPropertyContractNumber_valueText"))
                .TypeText(vpNo);
        }

        /// <summary>
        /// Sets the desired Business Template for apply the appropiate settings for limits, functions etc. in Frontoffice
        /// </summary>
        /// <param name="businessTemplate">default: "( Keine )"</param>
        public void SelectBusinessTemplate(String businessTemplate)
        {
            Driver.FindAdaptedElement(
                By.CssSelector("#ctl00_bodyContentPlaceHolder_acquirerUserControl_ddBusinessTemplate")).Selector().
                SelectByText(businessTemplate);
        }


        public void SetDcc(bool dccEnabeled)
        {
            var a = new ContractCreate(Driver);
            a.SetDcc(dccEnabeled);
        }

        public void SaveAndCreateBrand()
        {
            var cc = new ContractCreate(Driver);
            cc.SaveAndCreate();
        }
    }
}