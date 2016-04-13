using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows;
using DevOne.Security.Cryptography.BCrypt;
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
            //UserUtility.CreateUser("Admin", "admin");
        }

        private void LoginClick(object sender, RoutedEventArgs e)
        {
            SignIn(UsernameBox.Text.Trim(), passwordBox.Password.Trim());
        }

        private async void SignIn(string usernameTrimmed, string passwordTrimmed)
        {
            bool successfullyLoggedIn = await CheckUserDataSql(UsernameBox.Text.Trim(), passwordBox.Password.Trim());

            if (successfullyLoggedIn)
            {
                //navigate to window according to role
                //isloggedin = true
                await this.ShowMessageAsync("Sucess", "You have logged in.");
            }
            

        }

        /// <summary>
        /// Checks if user exists, and if password is correct.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        private async Task<bool> CheckUserDataSql(string username, string password)
        {
            List<string> userData;

            //Does the user exist?
            try
            {
                userData = await UserUtility.RetrieveUser(username);

            }
            catch (Exception ex)
            {
                await this.ShowMessageAsync("Error", ex.Message.ToString());
                return false;
            }

            //User does not exist
            if (userData == null)
            {
                await this.ShowMessageAsync("User not found", "User was not found. Please try again.");
                return false;
            }

            //User exists - check password
            return UserUtility.ValidatePassword(userData[3], password);
            
        }
    }
}