using System;
using Six.Scs.QA.Application.Model.Factory;

namespace Six.Scs.QA.Application.Workflow
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
                    String.Format("SYR {0} Infotext {1}", infotext, Factory.GenerateTestId());
            View.Common.Infotext.Create.SaveButton.Click();
            return infotext;
        }
    }
}