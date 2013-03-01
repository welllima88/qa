using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Extension.TestObjects;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Terminal
{ //STEP 2
    public class TerminalConfigDetailsCreate : WebObject
    {
        public bool Dcc;
        public Functionbits Functionbits;
        public bool Instalment;
        public bool PurchaseWithCashbackForced;
        public bool ReleaseChangeBlocked;

        public TerminalConfigDetailsCreate(IWebDriverAdapter driver) : base(driver)
        {
        }

        public string Article
        {
            get { return Driver.FindElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_lblArticleName")).Text; }
        }

        public string DeliveryDate
        {
            get
            {
                return
                    Driver.FindElement(
                        By.CssSelector(
                            "#ctl00_bodyContentPlaceHolder_terminalProperties_terminalPropertiesPropertyDeliveryDate_dtpDeliveryDate"))
                        .GetAttribute("value");
            }
            set
            {
                Driver.FindElement(
                    By.CssSelector(
                        "#ctl00_bodyContentPlaceHolder_terminalProperties_terminalPropertiesPropertyDeliveryDate_dtpDeliveryDate"))
                    .Clear();
                Driver.FindElement(
                    By.CssSelector(
                        "#ctl00_bodyContentPlaceHolder_terminalProperties_terminalPropertiesPropertyDeliveryDate_dtpDeliveryDate"))
                    .SendKeys(value);
            }
        }

        public string InstallType
        {
            set
            {
                Driver.FindAdaptedElement(
                    By.CssSelector(
                        "#ctl00_bodyContentPlaceHolder_terminalProperties_terminalPropertiesPropertyInstallType_ddInstallType"))
                    .Selector().SelectByText(value);
            }
        }

        public string InstallRemark
        {
            set
            {
                Driver.FindElement(
                    By.CssSelector(
                        "#ctl00_bodyContentPlaceHolder_terminalProperties_terminalPropertiesPropertyInstallType_inpInstallTypeRemark"))
                    .Clear();
                Driver.FindElement(
                    By.CssSelector(
                        "#ctl00_bodyContentPlaceHolder_terminalProperties_terminalPropertiesPropertyInstallType_inpInstallTypeRemark"))
                    .SendKeys(value);
            }
        }

        public string Contract
        {
            set
            {
                Driver.FindAdaptedElement(
                    By.CssSelector(
                        "#ctl00_bodyContentPlaceHolder_terminalProperties_terminalPropertiesPropertyContractType_ddHandoverType"))
                    .Selector().SelectByText(value);
            }
        }

        public string EcrInterface
        {
            set
            {
                Driver.FindAdaptedElement(
                    By.CssSelector(
                        "#ctl00_bodyContentPlaceHolder_terminalProperties_terminalPropertiesPropertyPosInterface_ddPosInterface"))
                    .Selector().SelectByText(value);
            }
        }

        public string EcrText
        {
            set
            {
                Driver.FindElement(
                    By.CssSelector(
                        "#ctl00_bodyContentPlaceHolder_terminalProperties_terminalPropertiesPropertyPosInterface_inpECRText"))
                    .Clear();
                Driver.FindElement(
                    By.CssSelector(
                        "#ctl00_bodyContentPlaceHolder_terminalProperties_terminalPropertiesPropertyPosInterface_inpECRText"))
                    .SendKeys(value);
            }
        }

        public string SupportContract
        {
            set
            {
                Driver.FindAdaptedElement(
                    By.CssSelector(
                        "#ctl00_bodyContentPlaceHolder_terminalProperties_terminalPropertiesPropertySupportLevel_ddSupportContract"))
                    .Selector().SelectByText(value);
            }
        }

        /// <summary>
        /// 5 rows á 32 characters
        /// </summary>
        public string ReceiptText
        {
            set
            {
                Driver.FindElement(
                    By.CssSelector(
                        "#ctl00_bodyContentPlaceHolder_terminalProperties_terminalPropertiesPropertyLine1_inpReceiptHeader"))
                    .Clear();
                Driver.FindElement(
                    By.CssSelector(
                        "#ctl00_bodyContentPlaceHolder_terminalProperties_terminalPropertiesPropertyLine1_inpReceiptHeader"))
                    .SendKeys(value);
            }


            get
            {
                return
                    Driver.FindElement(
                        By.CssSelector(
                            "#ctl00_bodyContentPlaceHolder_terminalProperties_terminalPropertiesPropertyLine1_inpReceiptHeader"))
                        .GetAttribute("value");
            }
        }

        public string NewSoftwareVersion
        {
            set
            {
                Driver.FindAdaptedElement(
                    By.CssSelector(
                        "#ctl00_bodyContentPlaceHolder_terminalProperties_terminalPropertiesPropertyCurrentReleaseId_ddNewReleaseId"))
                    .Selector().SelectByText(value);
            }
        }

        public IWebElement BackButton
        {
            get { return Driver.FindElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_wzNewTerminalBackButton")); }
        }

        public IWebElement SaveButton
        {
            get { return Driver.FindElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_wzNewTerminalFinishButton")); }
        }
    }
}