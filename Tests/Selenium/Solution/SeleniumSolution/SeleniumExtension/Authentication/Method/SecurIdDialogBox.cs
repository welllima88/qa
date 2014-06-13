using System.Windows.Forms;

namespace SIX.SCS.Tests.Selenium.Extension.Authentication.Method
{
    public class SecurIdDialogBox : IAuthentication
    {
        public void Login()
        {
            MessageBox.Show(@"please login in on to web page and confirm after successful authentication");
        }
    }
}