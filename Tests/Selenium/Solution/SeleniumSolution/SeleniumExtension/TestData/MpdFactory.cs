using Six.Scs.QA.Selenium.Extension.TestObjects.Definitions;

namespace Six.Scs.QA.Selenium.Extension.TestData
{
    public class MpdFactory
    {
        public static MpdData Create()
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