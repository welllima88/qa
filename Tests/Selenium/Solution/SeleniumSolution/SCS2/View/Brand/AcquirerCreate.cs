using OpenQA.Selenium;
using Six.Test.Selenium.WebDriver.WebElements;

namespace Six.Scs.Test.View.Brand
{
    public class AcquirerCreate : WebObject
    {
        public static string SetActivationDate
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_dtpSetupDate"))
                        .TextField()
                        .Text();
            }
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_dtpSetupDate"))
                    .TextField().TypeText(value);
            }
            //Check date format at this point? -> NOOO! In test method is right place
            //    Assert.IsTrue(Regex.IsMatch(WebDriver.FindAdaptedElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_dtpSetupDate")).TextBox().Text(), "[0-9]{2}.[0-9]{2}.[0-9]{4}"));
        }

        public static string Remark
        {
            set
            {
                WebDriver.FindAdaptedElement(By.Id("ContractCreateDto_Comment"))
                    .TextField()
                    .TypeText(value);
            }
        }

        /// <summary>
        ///     Sets for each acquirer, if the message (ticket, COI etc.) should be created or not
        /// </summary>
        /// <param name="acquirer">The name for acquirer e.g. "SIX Payment Services" or "American Express"</param>
        /// <param name="messageToAcquirer">set message should be created and send or not</param>
        public static void SetMessageToAcquirer(string acquirer, bool messageToAcquirer)
        {
            //Example: By.XPath("//span/div/label[text()='American Express']/preceding-sibling::input")).
            WebDriver.FindAdaptedElement(By.XPath("//span/div/label[text()='" + acquirer + "']/preceding-sibling::input"))
                .CheckBox().Set(messageToAcquirer);
        }

        /// <summary>
        ///     Sets for all acquirer, if the message (ticket, COI etc.) should be created or not
        /// </summary>
        /// <param name="messageToAcquirers">set message should be created and send or not</param>
        public static void SetMessageToAllAcquirers(bool messageToAcquirers)
        {
            var acquirers =
                WebDriver.FindAdaptedElements(By.CssSelector("input[id*='cbxAcquirerMessages'].check"));
            foreach (var acquirer in acquirers)
            {
                acquirer.CheckBox().Set(messageToAcquirers);
            }
        }

        public static void ConfirmAcquirerData()
        {
            WebDriver.FindAdaptedElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_lwpBrandsNextButton")).Click();
        }

        public static void SaveAndCreate()
        {
            Create.SaveAndCreate();
        }
    }
}