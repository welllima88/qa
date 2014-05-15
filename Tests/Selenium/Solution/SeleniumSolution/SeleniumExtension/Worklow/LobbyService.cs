using SIX.SCS.QA.Selenium.Extension.TestObjects.Common;

namespace SIX.SCS.QA.Selenium.Extension.Worklow
{
    public static class LobbyService
    {
        public static void Language(string language)
        {
            MetaNavBar.Languages.Click();
            MetaNavBar.Language(language).Click();
        }

        public static void OpenLatestElement()
        {
            NavigationBar.Lobby.Click();
            RecentElements.Latest.Click();
        }
    }
}