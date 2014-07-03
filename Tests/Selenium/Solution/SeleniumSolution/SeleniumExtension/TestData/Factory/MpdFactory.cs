using Six.Scs.QA.Selenium.Extension.TestData.ValueObjects;

namespace Six.Scs.QA.Selenium.Extension.TestData.Factory
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