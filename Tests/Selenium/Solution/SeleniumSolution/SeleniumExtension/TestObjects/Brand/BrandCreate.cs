using System;
using OpenQA.Selenium;
using Six.Scs.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.Extension.TestObjects.Brand
{
    public class BrandCreate : WebObject
//TODO contract create does not indicate precisely for which brand the properties should be set if multiple brand create executed
    {
        private BrandSelect _brandSelect;

        public BrandCreate()
        {
            _brandSelect = new BrandSelect();
            //throw new NotImplementedException();
        }

        public static void ClickBrandContractEdit(String brand)
        {
            ClickEditContract(brand, "contract");
        }

        public static void ClickAcquirerContractEdit(String acquirer)
        {
            ClickEditContract(acquirer, "brand");
        }

        private static void ClickEditContract(String brand, String brandType)
        {
            WebDriver.FindElement(
                By.CssSelector("div.title[textContent~=\"" + brand + "\"] input[src$=\"" + brandType + "_edit.gif\"]")).
                Click();
        }

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
                .TextBox()
                .TypeText(vpNo);
        }

        public static void SelectBusinessTemplate(String businessTemplate)
        {
            WebDriver.FindAdaptedElement(
                By.CssSelector("#ctl00_bodyContentPlaceHolder_acquirerUserControl_ddBusinessTemplate")).Selector().
                SelectByValue(businessTemplate);
        }

        public static void Dcc(bool dccEnabled)
        {
            WebDriver.FindAdaptedElement(By.CssSelector("input[id$='PropertyDCCflag_cbxDCC']"))
                .CheckBox()
                .Set(dccEnabled);
        }

        public static void SetDccBaseCurrency(String dccBaseCurrency)
        {
            WebDriver.FindElement(
                By.CssSelector("div[id*='PropertyDCCBaseCurrency'] div[value='" + dccBaseCurrency + "']"))
                .Click();
        }

        public static void SaveAndCreate()
        {
            WebDriver.FindElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_lwpBrandsFinishButton")).Click();
        }
    }
}