using System;
using System.Windows.Forms;

namespace SIX.SCS.QA.Selenium.Extension.Authentication.Method
{
    public partial class SecurIdDialogBox : Form, IAuthentication
    {
        private IAuthentication _authentication;

        public SecurIdDialogBox()
        {
            InitializeComponent();
            Show();
        }

        public void Login()
        {
            
        }

        private void DoLoginClick(object sender, EventArgs e)
        {
            // avoid second click/call
            Enabled = false;

            // just now take Data and do login 
            _authentication = new SecurIdAuthentication(userName.Text, password.Text, mandant.Text, securId.Text);
            _authentication.Login();
        }
    }
}