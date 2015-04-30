using System.Linq;
using Six.Scs.Test.View.Common;

namespace Six.Scs.Test.Workflow
{
    public static class Lobby
    {
        public static void ChooseLanguage(string language)
        {
            MetaNavBar.Languages.Click();
            MetaNavBar.LanguageItems.FirstOrDefault(e => e.Text.Contains(language));
        }

        public static void OpenLatestElement()
        {
            NavigationBar.Lobby.Click();
            RecentElements.Latest.Click();
        }
    }
}