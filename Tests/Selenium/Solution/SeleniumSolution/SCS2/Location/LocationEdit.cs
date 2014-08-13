using System;
using OpenQA.Selenium;
using Six.Scs.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.Location
{
    public class LocationEdit : WebObject
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
            set { LocationCreate.SapNumber = value; }
        }

        public static string CompanyName
        {
            set { LocationCreate.CompanyName = value; }
        }

        public static String SbsDebitNumber
        {
            get { return LocationView.SbsDebitNumber; }
        }

        public static String SbsAdressNumber
        {
            get { return LocationView.SbsAdressNumber; }
        }

        public static String Ep2MerchantId
        {
            get { return LocationView.Ep2MerchantId; }
        }

        public static string StreetNo
        {
            set { LocationCreate.StreetNo = value; }
        }

        public static string Language
        {
            set { LocationCreate.Language = value; }
            get { return LocationCreate.Language; }
        }

        public static string Country
        {
            set { LocationCreate.Country = value; }
            get { return LocationCreate.Country; }
        }

        public static string Zip
        {
            set { LocationCreate.Zip = value; }
            get { return LocationCreate.Zip; }
        }

        public static string City
        {
            set { LocationCreate.City = value; }
        }

        public static string AdressAddition
        {
            set { LocationCreate.AdressAddition = value; }
        }

        public static string Po
        {
            set { LocationCreate.Po = value; }
        }

        public static string Region
        {
            set { LocationCreate.Region = value; }
        }

        public static string Telephone
        {
            set { LocationCreate.Telephone = value; }
        }

        public static string Mobile
        {
            set { LocationCreate.Mobile = value; }
        }

        public static string Fax
        {
            set { LocationCreate.Fax = value; }
        }

        public static string Email
        {
            set { LocationCreate.Email = value; }
        }

        public static string Web
        {
            set { LocationCreate.Web = value; }
        }

        public static string Guid
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector(LocationRes.GUID)).Text; }
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