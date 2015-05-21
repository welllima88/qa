﻿using Six.Scs.Test.Model.Factory;

namespace Six.Scs.Test.Workflow
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
                View.Common.Infotext.Create.Text =
                    string.Format("SYR {0} Infotext {1}", infotext, Factory.GenerateTestId());
            View.Common.Infotext.Create.SaveButton.Click();
            return infotext;
        }
    }
}