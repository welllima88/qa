namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium.TestObjects.Definitions
{
    internal interface IAgency : IAdress
    {
        string Name { get; set; }
        string DisplayName { get; set; }
        string Supplier { get; set; }
    }
}