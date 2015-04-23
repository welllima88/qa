using System;
using System.Collections.ObjectModel;
using OpenQA.Selenium;
using Six.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.View.Brand
{
    public class AcquirerCreate : WebObject
    {
        public static String SetActivationDate
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

        public static String Remark
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
        public static void SetMessageToAcquirer(String acquirer, bool messageToAcquirer)
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
            ReadOnlyCollection<IWebElementAdapter> acquirers =
                WebDriver.FindAdaptedElements(By.CssSelector("input[id*='cbxAcquirerMessages'].check"));
            foreach (IWebElementAdapter acquirer in acquirers)
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