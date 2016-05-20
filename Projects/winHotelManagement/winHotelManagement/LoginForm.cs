using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MetroFramework;
using MetroFramework.Forms;

namespace winHotelManagement
{
    public partial class LoginForm : MetroForm
    {
        public LoginForm()
        {
            InitializeComponent();
            Focus();
            inputUsername.Focus();
        }

        /// <summary>
        ///     Attempts to log in.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            //try to sign in
            SignIn(inputUsername.Text.Trim(), inputPassword.Text.Trim());
        }

        /// <summary>
        /// Handels the sign in procss.
        /// </summary>
        /// <param name="usernameTrimmed">The username trimmed.</param>
        /// <param name="passwordTrimmed">The password trimmed.</param>
        private async void SignIn(string usernameTrimmed, string passwordTrimmed)
        {
            //true if correct username and password
            //false if correct username but wrong password
            bool correctLogin = false;

            try
            {
                 correctLogin = UserUtility.LogInUser(usernameTrimmed, passwordTrimmed);
            }
            catch (Exception ex)
            {
                //error occured, show messsage
                MetroMessageBox.Show(this, ex.Message);
            }

            if (correctLogin)
            {
                //navigate to window according to role
                //isloggedin = true

                MetroMessageBox.Show(this, "You have logged in");

                await Task.Delay(1000);

                FrontDesk frontDesk = new FrontDesk();
                frontDesk.Show();
                this.Hide();
            }
            else
            {
                MetroMessageBox.Show(this, "Wrong password!");
            }
        }
    }
}