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

        private async void SignIn(string usernameTrimmed, string passwordTrimmed)
        {
            //true if correct username and password
            //false if correct username but wrong password
            bool correctLogin = await CheckUserDataSql(usernameTrimmed, passwordTrimmed);

            if (correctLogin)
            {
                //navigate to window according to role
                //isloggedin = true

                MetroMessageBox.Show(this, "You have logged in");

                FrontDesk frontDesk = new FrontDesk();
                frontDesk.Show();
                Hide();
            }
            else
            {
                MetroMessageBox.Show(this, "Wrong password!");
            }
        }

        /// <summary>
        ///     Checks if user exists, and if password is correct.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns><c>True</c> if correct username and correct password.</returns>
        private async Task<bool> CheckUserDataSql(string username, string password)
        {
            //
            List<string> userData;

            //Does the user exist?
            try
            {
                userData = await UserUtility.RetrieveUser(username);
            }
            catch (Exception ex)
            {
                //error occured, show messsage
                MetroMessageBox.Show(this, ex.Message);
                return false;
            }

            //User exist
            if (userData != null)
                return UserUtility.ValidatePassword(userData[1], password);

            //User does not exist
            MetroMessageBox.Show(this, "User not found. Please try again.");
            return false;
        }
    }
}