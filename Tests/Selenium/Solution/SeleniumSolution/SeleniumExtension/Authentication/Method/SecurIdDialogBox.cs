using System.Windows.Forms;

namespace Six.Scs.QA.Selenium.Extension.Authentication.Method
{
    public class SecurIdDialogBox : IAuthentication
    {
        public void LogOn()
        {
            MessageBox.Show(@"please login in on to web page and confirm after successful authentication");
        }
    }
}