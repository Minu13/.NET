using Microsoft.Data.SqlClient;
using SampleBankingApp.DTOs;
using BCrypt.Net;
using System;

namespace SampleBankingApp.Services
{
    public class UserService : IUserService
    {
        private readonly string _connectionString;
        private readonly ILogger<UserService> _logger;

        public UserService(IConfiguration configuration, ILogger<UserService> logger)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");
            _logger = logger;
        }

        public bool RegisterUser(RegisterDTO user)
        {
            if (user.Password != user.ConfirmPassword)
                return false;

            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    conn.Open();

                    string query = "INSERT INTO Users (FullName, Email, PasswordHash, PhoneNumber, UserType) " +
                                   "VALUES (@FullName, @Email, @PasswordHash, @PhoneNumber, @UserType)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@FullName", user.FullName);
                        cmd.Parameters.AddWithValue("@Email", user.Email);


                        string hashedPassword = BCrypt.Net.BCrypt.HashPassword(user.Password);
                        cmd.Parameters.AddWithValue("@PasswordHash", hashedPassword);

                        cmd.Parameters.AddWithValue("@PhoneNumber", user.PhoneNumber);


                        cmd.Parameters.AddWithValue("@UserType", "Customer");


                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {

                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                _logger.LogError(ex, "SQL Error in RegisterUser");
                return false;
            }
            catch (Exception ex)
            {

                _logger.LogError(ex, "Error in RegisterUser");
                return false;
            }
        }


        public bool ValidateUser(string email, string password)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = "SELECT PasswordHash FROM Users WHERE Email = @Email";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Email", email);

                conn.Open();
                string storedHashedPassword = cmd.ExecuteScalar()?.ToString();


                bool isValid = storedHashedPassword != null && BCrypt.Net.BCrypt.Verify(password, storedHashedPassword);
                return isValid;
            }
        }

        public UserDTO GetUserByEmail(string email)
        {
            UserDTO user = null;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = "SELECT FullName, Email, UserType, PasswordHash FROM Users WHERE Email = @Email";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Email", email);

                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        user = new UserDTO
                        {
                            FullName = reader["FullName"] != DBNull.Value ? reader["FullName"].ToString() : "",
                            Email = reader["Email"] != DBNull.Value ? reader["Email"].ToString() : "",
                            UserType = reader["UserType"] != DBNull.Value ? reader["UserType"].ToString() : "Customer",
                            PasswordHash = reader["PasswordHash"] != DBNull.Value ? reader["PasswordHash"].ToString() : null
                        };
                    }
                }
            }

            return user;
        }
    }
}