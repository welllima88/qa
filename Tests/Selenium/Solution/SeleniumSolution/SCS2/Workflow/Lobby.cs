﻿using System.Linq;
using Six.Scs.Test.UI.Common;

namespace Six.Scs.Test.Workflow
{
    public static class Lobby
    {
        public static void ChooseLanguage(string language)
        {
            MetaNavBar.Languages.Click();
            MetaNavBar.LanguageItems.FirstOrDefault(e => e.Text.Contains(language)).Click();
        }

        public static void OpenLatestElement()
        {
            NavigationBar.Lobby.Click();
            RecentElements.Latest.Click();
        }
    }
}