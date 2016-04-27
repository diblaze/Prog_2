using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using DevOne.Security.Cryptography.BCrypt;

namespace winHotelManagement
{
    public static class UserUtility
    {
        private static string ConnectionString => Properties.Settings.Default.ConnectionString;

        /// <summary>
        ///     Retrives an given user.
        /// </summary>
        /// <param name="username">Username of given user.</param>
        /// <returns><c>SqlDataReader</c> with user data.</returns>
        public static async Task<List<string>> RetrieveUser(string username)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);

            //search for given username
            const string query = "SELECT * FROM Users WHERE Username=@username";
            SqlCommand sqlCommand = new SqlCommand(query, connection);
            SqlParameter usernameParameter = new SqlParameter("@username", SqlDbType.NVarChar);
            sqlCommand.Parameters.Add(usernameParameter);
            usernameParameter.Value = username;
            await connection.OpenAsync();

            var userData = new List<string>();

            using (SqlDataReader sqlReader = await sqlCommand.ExecuteReaderAsync())
            {
                while (await sqlReader.ReadAsync())
                {
                    userData.Add(sqlReader["Username"].ToString());
                    userData.Add(sqlReader["Hash"].ToString());
                    userData.Add(sqlReader["Role"].ToString());
                }
            }

            connection.Close();
            //send back userdata list.
            return userData;
        }

        /// <summary>
        ///     Creates a new user
        /// </summary>
        /// <param name="username">Username</param>
        /// <param name="password">Password</param>
        /// <returns><c>True</c> if successful</returns>
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
                await connection.OpenAsync();
                sqlCommand.ExecuteNonQuery();

                connection.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
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