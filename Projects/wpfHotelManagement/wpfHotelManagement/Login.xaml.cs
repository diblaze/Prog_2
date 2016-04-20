using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows;
using MahApps.Metro.Controls.Dialogs;

namespace wpfHotelManagement
{
    /// <summary>
    ///     Interaction logic for Login.xaml
    /// </summary>
    public partial class Login
    {
        public Login()
        {
            InitializeComponent();
        }

        private void LoginClick(object sender, RoutedEventArgs e)
        {
            //try to sign in
            SignIn(UsernameBox.Text.Trim(), passwordBox.Password.Trim());
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
                await this.ShowMessageAsync("Sucess", "You have logged in.");
                FrontDesk frontDesk = new FrontDesk();
                frontDesk.Show();
                Close();
                
            }
            else
            {
                await this.ShowMessageAsync("Failure", "Wrong password!");
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
                await this.ShowMessageAsync("Error", ex.Message);
                return false;
            }

            //User exist
            if (userData != null)
                return UserUtility.ValidatePassword(userData[1], password);

            //User does not exist
            await this.ShowMessageAsync("User not found", "User was not found. Please try again.");
            return false;
        }
    }
}