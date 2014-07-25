using NUnit.Framework;
using Six.Scs.QA.Selenium.Common;

namespace Six.Scs.QA.Testlogic
{
    public class Lobby
    {
        public static void Language(string language)
        {
            Workflow.Lobby.ChooseLanguage(language);
            Assert.AreEqual(language, MetaNavBar.ActualLanguage);
        }
    }
}