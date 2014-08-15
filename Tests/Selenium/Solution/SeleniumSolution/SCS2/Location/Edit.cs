using System;
using OpenQA.Selenium;
using Six.Scs.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.Location
{
    public class Edit : WebObject
    {
        public static IWebElementAdapter SaveButton
        {
            get { return WebDriver.FindAdaptedElement(By.Id("save")); }
        }

        public static IWebElementAdapter CancelButton
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("button[name='cancel']")); }
        }

        public static string SapNumber
        {
            set { Create.SapNumber = value; }
        }

        public static string CompanyName
        {
            set { Create.CompanyName = value; }
        }

        public static String SbsDebitNumber
        {
            get { return View.SbsDebitNumber; }
        }

        public static String SbsAdressNumber
        {
            get { return View.SbsAdressNumber; }
        }

        public static String Ep2MerchantId
        {
            get { return View.Ep2MerchantId; }
        }

        public static string StreetNo
        {
            set { Create.StreetNo = value; }
        }

        public static string Language
        {
            set { Create.Language = value; }
            get { return Create.Language; }
        }

        public static string Country
        {
            set { Create.Country = value; }
            get { return Create.Country; }
        }

        public static string Zip
        {
            set { Create.Zip = value; }
            get { return Create.Zip; }
        }

        public static string City
        {
            set { Create.City = value; }
        }

        public static string AdressAddition
        {
            set { Create.AdressAddition = value; }
        }

        public static string Po
        {
            set { Create.Po = value; }
        }

        public static string Region
        {
            set { Create.Region = value; }
        }

        public static string Telephone
        {
            set { Create.Telephone = value; }
        }

        public static string Mobile
        {
            set { Create.Mobile = value; }
        }

        public static string Fax
        {
            set { Create.Fax = value; }
        }

        public static string Email
        {
            set { Create.Email = value; }
        }

        public static string Web
        {
            set { Create.Web = value; }
        }

        public static string Guid
        {
            get { return WebDriver.FindAdaptedElement(By.Id("GUID")).Text; }
        }

        public static string Reason
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(By.Id("LocationData_NotificationReason"))
                        .Selector()
                        .SelectedOption;
            }
            set
            {
                WebDriver.FindAdaptedElement(By.Id("LocationData_NotificationReason")).Selector().SelectByValue(value);
            }
        }

        public static string ReasonRemark
        {
            get { return WebDriver.FindAdaptedElement(By.Id("LocationData_NotificationRemarks")).Text; }
            set { WebDriver.FindAdaptedElement(By.Id("LocationData_NotificationRemarks")).TextField().TypeText(value); }
        }
    }
}