using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Terminal
{ //STEP 2
    public class TerminalConfigDetailsCreate : WebObject
    {
        public bool Dcc;
        public Functionbits Functionbits;
        public bool Instalment;
        public bool PurchaseWithCashbackForced;
        public bool ReleaseChangeBlocked;

        public string Article
        {
            get { return WebDriver.FindElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_lblArticleName")).Text; }
        }

        public string DeliveryDate
        {
            get
            {
                return
                    WebDriver.FindElement(
                        By.CssSelector(
                            "#ctl00_bodyContentPlaceHolder_terminalProperties_terminalPropertiesPropertyDeliveryDate_dtpDeliveryDate"))
                             .GetAttribute("value");
            }
            set
            {
                WebDriver.FindAdaptedElement(
                    By.CssSelector(
                        "#ctl00_bodyContentPlaceHolder_terminalProperties_terminalPropertiesPropertyDeliveryDate_dtpDeliveryDate"))
                         .TypeText(value);
            }
        }

        public string InstallType
        {
            set
            {
                WebDriver.FindAdaptedElement(
                    By.CssSelector(
                        "#ctl00_bodyContentPlaceHolder_terminalProperties_terminalPropertiesPropertyInstallType_ddInstallType"))
                         .Selector().SelectByText(value);
            }
        }

        public string InstallRemark
        {
            set
            {
                WebDriver.FindAdaptedElement(
                    By.CssSelector(
                        "#ctl00_bodyContentPlaceHolder_terminalProperties_terminalPropertiesPropertyInstallType_inpInstallTypeRemark"))
                         .TypeText(value);
            }
        }

        public string Contract
        {
            set
            {
                WebDriver.FindAdaptedElement(
                    By.CssSelector(
                        "#ctl00_bodyContentPlaceHolder_terminalProperties_terminalPropertiesPropertyContractType_ddHandoverType"))
                         .Selector().SelectByText(value);
            }
        }

        public string EcrInterface
        {
            set
            {
                WebDriver.FindAdaptedElement(
                    By.CssSelector(
                        "#ctl00_bodyContentPlaceHolder_terminalProperties_terminalPropertiesPropertyPosInterface_ddPosInterface"))
                         .Selector().SelectByText(value);
            }
        }

        public string EcrText
        {
            set
            {
                WebDriver.FindAdaptedElement(
                    By.CssSelector(
                        "#ctl00_bodyContentPlaceHolder_terminalProperties_terminalPropertiesPropertyPosInterface_inpECRText"))
                         .TypeText(value);
            }
        }

        public string SupportContract
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
        public string ReceiptText
        {
            set
            {
                WebDriver.FindAdaptedElement(
                    By.CssSelector(
                        "#ctl00_bodyContentPlaceHolder_terminalProperties_terminalPropertiesPropertyLine1_inpReceiptHeader"))
                         .TypeText(value);
            }

            get
            {
                return
                    WebDriver.FindElement(
                        By.CssSelector(
                            "#ctl00_bodyContentPlaceHolder_terminalProperties_terminalPropertiesPropertyLine1_inpReceiptHeader"))
                             .GetAttribute("value");
            }
        }

        public string NewSoftwareVersion
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

        public IWebElement SaveButton
        {
            get { return WebDriver.FindElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_wzNewTerminalFinishButton")); }
        }
    }
}