namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium.TestObjects.Definitions
{
    /// <summary>
    /// defines the ways and media how to contact 
    /// </summary>
    public interface IContact
    {
        string Language { set; get; }
        string Telephone { set; get; }
        string Mobile { set; get; }
        string Fax { set; get; }
        string Email { set; get; }
        string Web { get; set; }
    }
}