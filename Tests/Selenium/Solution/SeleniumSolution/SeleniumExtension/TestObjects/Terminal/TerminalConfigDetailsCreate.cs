using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension.Selenium.WebElements;

namespace SIX.SCS.QA.Selenium.Extension.TestObjects.Terminal
{ //STEP 2
    public class TerminalConfigDetailsCreate : WebObject
    {
        public bool Dcc;
        public Functionbits Functionbits;
        public bool Instalment;
        public bool PurchaseWithCashbackForced;
        public bool ReleaseChangeBlocked;

        public static string Article
        {
            get { return WebDriver.FindElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_lblArticleName")).Text; }
        }

        public static string DeliveryDate
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(
                        By.CssSelector(
                            "#ctl00_bodyContentPlaceHolder_terminalProperties_terminalPropertiesPropertyDeliveryDate_dtpDeliveryDate"))
                             .TextBox().Text();
            }
            set
            {
                WebDriver.FindAdaptedElement(
                    By.CssSelector(
                        "#ctl00_bodyContentPlaceHolder_terminalProperties_terminalPropertiesPropertyDeliveryDate_dtpDeliveryDate"))
                         .TextBox().TypeText(value);
            }
        }

        public static string InstallType
        {
            set
            {
                WebDriver.FindAdaptedElement(
                    By.CssSelector(
                        "#ctl00_bodyContentPlaceHolder_terminalProperties_terminalPropertiesPropertyInstallType_ddInstallType"))
                         .Selector().SelectByText(value);
            }
        }

        public static string InstallRemark
        {
            set
            {
                WebDriver.FindAdaptedElement(
                    By.CssSelector(
                        "#ctl00_bodyContentPlaceHolder_terminalProperties_terminalPropertiesPropertyInstallType_inpInstallTypeRemark"))
                         .TextBox().TypeText(value);
            }
        }

        public static string Contract
        {
            set
            {
                WebDriver.FindAdaptedElement(
                    By.CssSelector(
                        "#ctl00_bodyContentPlaceHolder_terminalProperties_terminalPropertiesPropertyContractType_ddHandoverType"))
                         .Selector().SelectByText(value);
            }
        }

        public static string EcrInterface
        {
            set
            {
                WebDriver.FindAdaptedElement(
                    By.CssSelector(
                        "#ctl00_bodyContentPlaceHolder_terminalProperties_terminalPropertiesPropertyPosInterface_ddPosInterface"))
                         .Selector().SelectByText(value);
            }
        }

        public static string EcrText
        {
            set
            {
                WebDriver.FindAdaptedElement(
                    By.CssSelector(
                        "#ctl00_bodyContentPlaceHolder_terminalProperties_terminalPropertiesPropertyPosInterface_inpECRText"))
                         .TextBox().TypeText(value);
            }
        }

        public static string SupportContract
        {
            set
            {
                WebDriver.FindAdaptedElement(
                    By.CssSelector(
                        "#ctl00_bodyContentPlaceHolder_terminalProperties_terminalPropertiesPropertySupportLevel_ddSupportContract"))
                         .Selector().SelectByText(value);
            }
        }

        /// <summary>
        ///     5 rows á 32 characters
        /// </summary>
        public static string ReceiptText
        {
            set
            {
                WebDriver.FindAdaptedElement(
                    By.CssSelector(
                        "#ctl00_bodyContentPlaceHolder_terminalProperties_terminalPropertiesPropertyLine1_inpReceiptHeader"))
                         .TextBox().TypeText(value);
            }

            get
            {
                return
                    WebDriver.FindAdaptedElement(
                        By.CssSelector(
                            "#ctl00_bodyContentPlaceHolder_terminalProperties_terminalPropertiesPropertyLine1_inpReceiptHeader"))
                             .TextBox().Text();
            }
        }

        public static string NewSoftwareVersion
        {
            set
            {
                WebDriver.FindAdaptedElement(
                    By.CssSelector(
                        "#ctl00_bodyContentPlaceHolder_terminalProperties_terminalPropertiesPropertyCurrentReleaseId_ddNewReleaseId"))
                         .Selector().SelectByText(value);
            }
        }

        public IWebElement BackButton
        {
            get { return WebDriver.FindElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_wzNewTerminalBackButton")); }
        }

        public static IWebElement SaveButton
        {
            get { return WebDriver.FindElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_wzNewTerminalFinishButton")); }
        }
    }
}