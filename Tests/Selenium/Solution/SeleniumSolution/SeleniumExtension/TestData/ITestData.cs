namespace Six.Scs.Tests.Selenium.Extension.TestData
{
    public interface ITestData
    {
        ITestData GetAny();
        ITestData GetById(string id);
        string GetUrlPart();
    }
}