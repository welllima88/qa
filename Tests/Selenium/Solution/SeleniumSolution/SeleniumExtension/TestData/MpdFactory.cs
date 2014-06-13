using SIX.SCS.Tests.Selenium.Extension.TestObjects.Definitions;

namespace SIX.SCS.Tests.Selenium.Extension.TestData
{
    public class MpdFactory
    {
        public MpdData Create()
        {
            return new MpdData
            {
                Adress = "Adress",
                Port = "Port",
                Description = "SYR MPD" + Factory.GenerateTestId()
            };
        }
    }
}