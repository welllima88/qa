using System;
using OpenQA.Selenium;
using Six.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.Brand
{
    public class Edit : WebObject
    {
        /// <summary>
        ///     Clicks edit on the desired brand
        /// </summary>
        /// <param name="brand">brand name e.g. "American Express [635]"</param>
        public static void ClickBrandContractEdit(String brand)
        {
            ClickEditContract(brand, "contract");
        }

        /// <summary>
        ///     /// Clicks edit on the desired acquirer
        /// </summary>
        /// <param name="acquirer">"Protokoll EP2 [281]" for SIX Payment Services (Multipay)</param>
        public static void ClickAcquirerContractEdit(String acquirer)
        {
            ClickEditContract(acquirer, "brand");
        }

        private static void ClickEditContract(String brand, String brandType)
        {
            WebDriver.FindAdaptedElement(
                By.CssSelector("div.title[textContent~=\"" + brand + "\"] input[src$=\"" + brandType + "_edit.gif\"]")).
                Click();
        }

        /// <summary>
        ///     Sets the MCC (merchant category code)
        /// </summary>
        /// <param name="mcc">e.g. "5111: STATIONERY/OFF-SUPP/PRINTING"</param>
        public static void SelectMcc(String mcc)
        {
            WebDriver.FindAdaptedElement(
                By.CssSelector(
                    "#ctl00_bodyContentPlaceHolder_acquirerUserControl_acquirerUserControlPropertyCategoryCode_sugCategoryCode"))
                .Selector().SelectByText(mcc);
        }

        public static void SetVpNo(String vpNo)
        {
            WebDriver.FindAdaptedElement(
                By.CssSelector(
                    "#ctl00_bodyContentPlaceHolder_acquirerUserControl_acquirerUserControlPropertyContractNumber_valueText"))
                .TextField()
                .TypeText(vpNo);
        }

        /// <summary>
        ///     Sets the desired Business Template for apply the appropiate settings for limits, functions etc. in Frontoffice
        /// </summary>
        /// <param name="businessTemplate">default: "( Keine )"</param>
        public static void SelectBusinessTemplate(String businessTemplate)
        {
            WebDriver.FindAdaptedElement(
                By.CssSelector("#ctl00_bodyContentPlaceHolder_acquirerUserControl_ddBusinessTemplate")).Selector().
                SelectByText(businessTemplate);
        }

        public static void Dcc(bool dccEnabeled)
        {
            Create.Dcc(dccEnabeled);
        }

        public static void SaveAndCreate()
        {
            Create.SaveAndCreate();
        }
    }
}