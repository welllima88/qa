using System;
using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Brand
{
    public class ContractView : WebObject
    {
        public ContractView()
        {
            throw new NotImplementedException(); //everything done?? -> no, get List and data for brands (on terminal)
        }

        /// <summary>
        ///     calls Edit page for desired brand (sub contract/provider)
        /// </summary>
        /// <param name="brand">use for example as parameter "American Express [635]"</param>
        public void ClickBrandContractEdit(String brand)
        {
            //American Express [635]
            ClickEditContract(brand, "contract");
        }

        /// <summary>
        ///     calls Edit page for desired acquirer (main contract/provider)
        /// </summary>
        /// <param name="acquirer">for example "Multipay ep2" needs as parameter "Protokoll EP2 [281]"</param>
        public void ClickAcquirerContractEdit(String acquirer)
        {
            ClickEditContract(acquirer, "brand");
        }

        /// <summary>
        ///     helper method
        /// </summary>
        /// <param name="brand"></param>
        /// <param name="brandType"></param>
        private void ClickEditContract(String brand, String brandType)
        {
            WebDriver.FindElement(
                By.CssSelector("div.title[textContent~=\"" + brand + "\"] input[src$=\"" + brandType + "_edit.gif\"]")).
                      Click();
        }

        /// <summary>
        /// </summary>
        /// <param name="mcc">use for example "5111: STATIONERY/OFF-SUPP/PRINTING"</param>
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

        /// <summary>
        ///     Selects an FO template and overrides the default setting (in Frontoffice)
        /// </summary>
        /// <param name="businessTemplate">use for example "( Keine )"</param>
        public void SelectBusinessTemplate(String businessTemplate)
        {
            WebDriver.FindAdaptedElement(
                By.CssSelector("#ctl00_bodyContentPlaceHolder_acquirerUserControl_ddBusinessTemplate")).Selector().
                      SelectByText(businessTemplate);
        }
    }
}