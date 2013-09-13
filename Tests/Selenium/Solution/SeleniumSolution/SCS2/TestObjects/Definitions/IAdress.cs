namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium.TestObjects.Definitions
{
    public interface IAdress
    {
        string StreetNo { set; get; }
        string Country { set; get; }
        string Zip { set; get; }
        string City { set; get; }
        string AdressAddition { set; get; }
        string Po { set; get; }
        string Region { set; get; }
    }
}