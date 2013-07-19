using System;
using System.Windows.Forms;

namespace SIX.SCS.QA.Selenium.Extension.Authentication.Method
{
    public partial class SecurIdDialogBox : Form
    {
        public SecurIdDialogBox()
        {
            InitializeComponent();
        }

        public void DoLoginClick(object sender, EventArgs e)
        {
            // avoid second click then (try) login
            Enabled = false;
        }
    }
}