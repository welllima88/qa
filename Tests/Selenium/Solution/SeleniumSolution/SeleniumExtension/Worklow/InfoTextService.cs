using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.Selenium.Extension.TestData;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Common.Infotext;

namespace SIX.SCS.QA.Selenium.Extension.Worklow
{
    public static class InfoTextService
    {
        /// <summary>
        /// This implies, that the create infotext button is displayed
        /// </summary>
        /// <param name="infotext">Substring to create an Infotext</param>
        public static void Create(string infotext)
        {
            infotext =
                InfoTextCreate.Text = String.Format("SYR {0} Infotext {1}", infotext, Factory.GenerateTestId());
            InfoTextCreate.SaveButton.Click();
            Assert.IsTrue(InfoTextListView.List.Contains(infotext));
        }
    }
}