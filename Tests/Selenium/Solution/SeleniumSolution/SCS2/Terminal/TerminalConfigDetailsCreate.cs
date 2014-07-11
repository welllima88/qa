using OpenQA.Selenium;
using Six.Scs.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.Terminal
{ //STEP 2

    public class TerminalConfigDetailsCreate : WebObject
    {
        public static string Article
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_lblArticleName")).Text; }
        }

        public static string DeliveryDate
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(
                        By.CssSelector(
                            "#ctl00_bodyContentPlaceHolder_terminalProperties_terminalPropertiesPropertyDeliveryDate_dtpDeliveryDate"))
                        .TextField().Text();
            }
            set
            {
                WebDriver.FindAdaptedElement(
                    By.CssSelector(
                        "#ctl00_bodyContentPlaceHolder_terminalProperties_terminalPropertiesPropertyDeliveryDate_dtpDeliveryDate"))
                    .TextField().TypeText(value);
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
                    .TextField().TypeText(value);
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
                    .TextField().TypeText(value);
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
                    .TextField().TypeText(value);
            }

            get
            {
                return
                    WebDriver.FindAdaptedElement(
                        By.CssSelector(
                            "#ctl00_bodyContentPlaceHolder_terminalProperties_terminalPropertiesPropertyLine1_inpReceiptHeader"))
                        .TextField().Text();
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

        public static IWebElementAdapter BackButton
        {
            get
            {
                return WebDriver.FindAdaptedElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_wzNewTerminalBackButton"));
            }
        }

        public static IWebElementAdapter SaveButton
        {
            get
            {
                return WebDriver.FindAdaptedElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_wzNewTerminalFinishButton"));
            }
        }
    }
}