using Six.Scs.Tests.Selenium.Extension.TestObjects.Definitions;

namespace Six.Scs.Tests.Selenium.Extension.TestData
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