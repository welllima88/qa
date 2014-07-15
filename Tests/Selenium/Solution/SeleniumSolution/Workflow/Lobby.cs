using Six.Scs.QA.Selenium.Common;

namespace Six.Scs.QA.Workflow
{
    public static class Lobby
    {
        public static void ChooseLanguage(string language)
        {
            MetaNavBar.Languages.Click();
            MetaNavBar.LanguageItem(language).Click();
        }

        public static void OpenLatestElement()
        {
            NavigationBar.Lobby.Click();
            RecentElements.Latest.Click();
        }
    }
}