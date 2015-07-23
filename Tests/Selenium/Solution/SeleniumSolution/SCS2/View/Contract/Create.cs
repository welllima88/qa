using OpenQA.Selenium;
using Six.Test.Selenium.WebDriver.WebElements;

namespace Six.Scs.Test.View.Contract
{
    public class Create : WebObject
//TODO contract create does not indicate precisely for which brand the properties should be set if multiple brand create executed
    {
        public static void ClickBrandContractEdit(string brand)
        {
            ClickEditContract(brand, "contract");
        }

        public static void ClickAcquirerContractEdit(string acquirer)
        {
            ClickEditContract(acquirer, "brand");
        }

        private static void ClickEditContract(string brand, string brandType)
        {
            WebDriver.FindAdaptedElement(
                By.CssSelector("div.title[textContent~=\"" + brand + "\"] input[src$=\"" + brandType + "_edit.gif\"]")).
                Click();
        }

        public static void SelectMcc(string mcc)
        {
            WebDriver.FindAdaptedElement(
                By.CssSelector(
                    "#ctl00_bodyContentPlaceHolder_acquirerUserControl_acquirerUserControlPropertyCategoryCode_sugCategoryCode"))
                .Selector().SelectByText(mcc);
        }

        public static void SetVpNo(string vpNo)
        {
            WebDriver.FindAdaptedElement(
                By.CssSelector(
                    "#ctl00_bodyContentPlaceHolder_acquirerUserControl_acquirerUserControlPropertyContractNumber_valueText"))
                .TextField()
                .TypeText(vpNo);
        }

        public static void SelectBusinessTemplate(string businessTemplate)
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

        public static void SetDccBaseCurrency(string dccBaseCurrency)
        {
            WebDriver.FindAdaptedElement(
                By.CssSelector("div[id*='PropertyDCCBaseCurrency'] div[value='" + dccBaseCurrency + "']"))
                .Click();
        }

        public static void SaveAndCreate()
        {
            WebDriver.FindAdaptedElement(By.Id("save")).Click();
        }
    }
}