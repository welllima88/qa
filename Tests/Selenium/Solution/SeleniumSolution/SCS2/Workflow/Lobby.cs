using System.Linq;
using Six.Scs.QA.Application.View.Common;

namespace Six.Scs.QA.Application.Workflow
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