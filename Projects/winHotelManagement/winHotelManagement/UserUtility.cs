using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Net.Sockets;
using System.Threading.Tasks;
using DevOne.Security.Cryptography.BCrypt;
using System.Linq;
using MetroFramework;

namespace winHotelManagement
{
    public static class UserUtility
    {

        /// <summary>
        ///     Retrives an given user.
        /// </summary>
        /// <param name="username">Username of given user.</param>
        /// <returns><c>True</c> if correct user data. <c>False</c> if incorrect user data.</returns>
        public static bool LogInUser(string username, string password)
        {
            bool correctPassword = false;

            //LINQ to SQL
            HotelDataDataContext db = new HotelDataDataContext();

            IEnumerable<User> users = from u in db.Users
                                      where u.Username == username
                                      select u;

            //we found a user
            if (users.Count() == 1)
            {
                //check password against user.
                correctPassword = ValidatePassword(users.FirstOrDefault()?.Hash, password);
            }

            return correctPassword;
        }

        /// <summary>
        ///     Creates a new user
        /// </summary>
        /// <param name="username">Username</param>
        /// <param name="password">Password</param>
        /// <returns><c>True</c> if successful</returns>
        public static bool CreateUser(string username, string password)
        {

            //hash password
            string passwordHash = BCryptHelper.HashPassword(password, BCryptHelper.GenerateSalt());
            //role to set to user
            string role = "Employee";

            //LINQ to SQL
            HotelDataDataContext db = new HotelDataDataContext();

            try
            {
                User newUser = new User {Hash = passwordHash, Username = username, Role = role};
                db.Users.InsertOnSubmit(newUser);
                db.SubmitChanges();

            }
            catch (Exception)
            {
                return false;
            }

            return true;

        }

        /// <summary>
        ///     Validates the given password against the given username.
        /// </summary>
        /// <param name="correctHash">The stored correct hash for user's password.</param>
        /// <param name="password">User's password in plain text.</param>
        /// <returns>
        ///     <c>True</c> if correct password
        ///     <c>False</c> if wrong password
        /// </returns>
        public static bool ValidatePassword(string correctHash, string password)
        {
            return BCryptHelper.CheckPassword(password, correctHash);
        }
    }
}