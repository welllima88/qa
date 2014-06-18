using Six.Scs.QA.Selenium.Extension.TestObjects.Common;

namespace Six.Scs.QA.Selenium.Extension.Worklow
{
    public static class LobbyService
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