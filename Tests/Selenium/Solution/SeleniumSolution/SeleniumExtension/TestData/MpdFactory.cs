using SIX.SCS.QA.Selenium.Extension.TestObjects.Definitions;

namespace SIX.SCS.QA.Selenium.Extension.TestData
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