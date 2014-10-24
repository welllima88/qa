using System;
using Six.Scs.QA.TestData.Factory;

namespace Six.Scs.QA.Workflow
{
    public static class InfoText
    {
        /// <summary>
        ///     This implies, that the create infotext button is displayed
        /// </summary>
        /// <param name="infotext">Substring to create an Infotext</param>
        public static string Create(string infotext)
        {
            infotext =
                Selenium.Common.Infotext.Create.Text =
                    String.Format("SYR {0} Infotext {1}", infotext, Factory.GenerateTestId());
            Selenium.Common.Infotext.Create.SaveButton.Click();
            return infotext;
        }
    }
}