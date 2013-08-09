using System;
using System.Threading;
using System.Windows.Forms;

namespace SIX.SCS.QA.Selenium.Extension.Authentication.Method
{
    public partial class SecurIdDialogBox : Form, IAuthentication
    {
        private IAuthentication _authentication;
        private bool _loginActionPerformed;

        public SecurIdDialogBox()
        {
            InitializeComponent();
        }

        // todo doesn't work to prompt for user input (because of testing framework??), alternatively wait for "onButtonPressed" of Webpage?
        public void Login()
        {
            var wp = new Thread(WaitForLoginButtonPressed);
            wp.Name = "WaitForLoginThread";
            wp.Start();
            wp.Join();
        }

        public void WaitForLoginButtonPressed()
        {
            while (!_loginActionPerformed)
            {
                // wait active for loginButton was pressed
                Thread.Sleep(88);
            }
            PerformLogin();
        }

        private void PerformLogin()
        {
            _authentication = new SecurIdAuthentication(userName.Text, password.Text, mandant.Text, securId.Text);
            _authentication.Login();
        }

        private void OnLoginButtonClicked(object sender, EventArgs e)
        {
            // prevent second click/call and 'tell' that login shall be performed
            loginButton.Enabled = false;
            _loginActionPerformed = true;
        }
    }
}