using Microsoft.Data.SqlClient;
using SampleBankingApp.DTOs;
using System.Data;

namespace SampleBankingApp.Services
{
    public class DashboardService : IDashboardService
    {
        private readonly string _connectionString;

        public DashboardService(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        public async Task<UserDashboardDTO> GetUserDashboard(string email)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                await conn.OpenAsync();

                using (SqlCommand cmd = new SqlCommand("sp_GetUserDashboard", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Email", email);

                    using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                    {
                        UserDashboardDTO dashboard = new UserDashboardDTO();

                        if (await reader.ReadAsync())
                        {
                            dashboard = new UserDashboardDTO
                            {
                                FullName = reader["FullName"].ToString(),
                                AccountNumber = reader["AccountNumber"].ToString(),
                                AccountType = reader["AccountType"].ToString(),
                                Balance = Convert.ToDecimal(reader["Balance"]),
                                Transactions = new List<TransactionDTO>()
                            };
                        }

                        if (reader.NextResult())
                        {
                            while (await reader.ReadAsync())
                            {
                                dashboard.Transactions.Add(new TransactionDTO
                                {
                                    TransactionId = Convert.ToInt32(reader["TransactionId"]),
                                    Amount = Convert.ToDecimal(reader["Amount"]),
                                    TransactionType = reader["TransactionType"].ToString(),
                                    TransactionDate = Convert.ToDateTime(reader["TransactionDate"]),
                                    Description = reader["Description"].ToString()
                                });
                            }
                        }

                        return dashboard;
                    }
                }
            }
        }

        public async Task<AccountDTO> GetAccountById(int accountId)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                await conn.OpenAsync();

                using (SqlCommand cmd = new SqlCommand("SELECT AccountID, AccountNumber, AccountType, Balance FROM Accounts WHERE AccountID = @AccountID", conn))
                {
                    cmd.Parameters.AddWithValue("@AccountID", accountId);

                    using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                    {
                        if (await reader.ReadAsync())
                        {
                            return new AccountDTO
                            {
                                AccountId = Convert.ToInt32(reader["AccountID"]),
                                AccountNumber = reader["AccountNumber"].ToString(),
                                AccountType = reader["AccountType"].ToString(),
                                Balance = Convert.ToDecimal(reader["Balance"])
                            };
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
            }
        }
        public async Task<AccountDTO> GetAccountByEmail(string email)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                await conn.OpenAsync();

                using (SqlCommand cmd = new SqlCommand(@"
            SELECT a.AccountID, a.AccountNumber, a.AccountType, a.Balance
            FROM Accounts a
            INNER JOIN Users u ON u.UserID = a.UserID
            WHERE u.Email = @Email", conn))
                {
                    cmd.Parameters.AddWithValue("@Email", email);

                    using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                    {
                        if (await reader.ReadAsync())
                        {
                            return new AccountDTO
                            {
                                AccountId = Convert.ToInt32(reader["AccountID"]),
                                AccountNumber = reader["AccountNumber"].ToString(),
                                AccountType = reader["AccountType"].ToString(),
                                Balance = Convert.ToDecimal(reader["Balance"])
                            };
                        }
                        else
                        {
                            return null; 
                        }
                    }
                }
            }
        }
    }
}