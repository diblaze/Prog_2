using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Documents;
using DevOne.Security.Cryptography.BCrypt;

namespace wpfHotelManagement
{
    public static class UserUtility
    {
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
        ///     Retrives an given user.
        /// </summary>
        /// <param name="username">Username of given user.</param>
        /// <returns>SqlDataReader with user data.</returns>
        public static async Task<List<string>> RetrieveUser(string username)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);

            //search for given username
            const string query = "SELECT * FROM Users WHERE Username=@username";
            SqlCommand sqlCommand = new SqlCommand(query, connection);
            SqlParameter usernameParameter = new SqlParameter("@username", SqlDbType.NVarChar);
            sqlCommand.Parameters.Add(usernameParameter);
            usernameParameter.Value = username;
            connection.Open();

            //SqlDataReader sqlReader = await sqlCommand.ExecuteReaderAsync();

            var userData = new List<string>();

            using (SqlDataReader sqlReader = sqlCommand.ExecuteReader())
            {
                while (sqlReader.Read())
                {
                    userData.Add(sqlReader));
                }
            }

            //if we did get an hit on username - add data to userdata list
            var userData = new List<string>();
            userData.AddRange(from DataRow row in sqlReader select row.ToString());

            connection.Close();
            //send back userdata list.
            return userData;
        }

        public static async Task<bool> CreateUser(string username, string password)
        {
            const string query = "INSERT INTO Users (Username, Hash, Role) VALUES(@username, @hash, @role)";

            string passwordHash = BCryptHelper.HashPassword(password, BCryptHelper.GenerateSalt());

            try
            {
                SqlConnection connection = new SqlConnection(ConnectionString);
                SqlCommand sqlCommand = new SqlCommand(query, connection);
                SqlParameter usernameParameter = new SqlParameter("@username", SqlDbType.NVarChar);
                SqlParameter hashParameter = new SqlParameter("@hash", SqlDbType.NVarChar);
                SqlParameter roleParameter = new SqlParameter("@role", SqlDbType.NVarChar);
                sqlCommand.Parameters.Add(usernameParameter);
                sqlCommand.Parameters.Add(hashParameter);
                sqlCommand.Parameters.Add(roleParameter);
                usernameParameter.Value = username;
                hashParameter.Value = passwordHash;
                //TODO: make sure Admin can change the role depending on what he needs.
                roleParameter.Value = "Admin";
                connection.Open();
                int r=sqlCommand.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                return false;
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