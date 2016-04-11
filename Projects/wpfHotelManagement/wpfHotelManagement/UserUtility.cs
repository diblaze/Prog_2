using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using DevOne.Security.Cryptography.BCrypt;

namespace wpfHotelManagement
{
    public static class UserUtility
    {
        /// <summary>
        /// Retrives an given user.
        /// </summary>
        /// <param name="username">Username of given user.</param>
        /// <returns>SqlDataReader with user data.</returns>
        public static async Task<List<string>> RetrieveUser(string username)
        {
            SqlConnection connection =
                new SqlConnection(ConnectionString);

            //search for given username
            const string query = "SELECT * FROM Users WHERE Username=@username";
            SqlCommand sqlCommand = new SqlCommand(query, connection);
            SqlParameter usernameParameter = new SqlParameter("@username", SqlDbType.NVarChar);
            sqlCommand.Parameters.Add(usernameParameter);
            usernameParameter.Value = username;
            connection.Open();

            SqlDataReader sqlReader =  await sqlCommand.ExecuteReaderAsync();

            //if we did not get an hit on username, return null
            if (sqlReader.HasRows)
            {
                return null;
            }

            //if we did get an hit on username - add data to userdata list
            List<string> userData = new List<string>();
            userData.AddRange(from DataRow row in sqlReader select row.ToString());

            connection.Close();
            //send back userdata list.
            return userData;
        }

        public static async Task<bool> CreateUser(string username, string password)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);

            const string query = "INSERT INTO Users (Username, Hash, Role) VALUES(@username, @hash, @role)";

            string passwordHash = BCryptHelper.HashPassword(password, BCryptHelper.GenerateSalt());


            SqlCommand sqlCommand = new SqlCommand(query, connection);
        }

        private static string ConnectionString
        {
            get
            {
                //fix connectionstring to be relative.
                string connectionString = ConfigurationManager.ConnectionStrings["defaultConnection"].ConnectionString;
                connectionString = connectionString.Replace("{WorkingDirectory}", AppDomain.CurrentDomain.BaseDirectory);
                return connectionString;
            }
        }

        /// <summary>
        ///     Validates the given password against the given username.
        /// </summary>
        /// <param name="correctHash">The stored correct hash for user's password.</param>
        /// <param name="password">User's password in plain text.</param>
        /// <returns></returns>
        public static bool ValidatePassword(string correctHash, string password)
        {
            return BCryptHelper.CheckPassword(password, correctHash);
        }
    }
}