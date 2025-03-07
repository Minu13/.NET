using Microsoft.Data.SqlClient;
using SampleBankingApp.DTOs;

namespace SampleBankingApp.Services
{
    public class TransactionService : ITransactionService
    {
        private readonly string _connectionString;

        public TransactionService(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        public async Task ProcessTransaction(TransactionDTO transactionDto)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                await conn.OpenAsync();

               
                SqlTransaction sqlTransaction = conn.BeginTransaction();

                try
                {

                    string insertTransactionQuery = @"
                INSERT INTO Transactions (AccountID, Amount, TransactionType, TransactionDate, Description)
                VALUES (@AccountID, @Amount, @TransactionType, GETDATE(), @Description);";

                    using (SqlCommand cmd = new SqlCommand(insertTransactionQuery, conn, sqlTransaction))
                    {
                        cmd.Parameters.AddWithValue("@AccountID", transactionDto.AccountId);
                        cmd.Parameters.AddWithValue("@Amount", transactionDto.Amount);
                        cmd.Parameters.AddWithValue("@TransactionType", transactionDto.TransactionType);
                        cmd.Parameters.AddWithValue("@Description", transactionDto.Description ?? (object)DBNull.Value);

                        await cmd.ExecuteNonQueryAsync();
                    }


                    string updateBalanceQuery = @"
                UPDATE Accounts
                SET Balance = Balance + @Amount
                WHERE AccountID = @AccountID;";

                    using (SqlCommand cmd = new SqlCommand(updateBalanceQuery, conn, sqlTransaction))
                    {
                        cmd.Parameters.AddWithValue("@AccountID", transactionDto.AccountId);
                        cmd.Parameters.AddWithValue("@Amount", transactionDto.Amount);

                        await cmd.ExecuteNonQueryAsync();
                    }


                    sqlTransaction.Commit();
                }
                catch
                {

                    sqlTransaction.Rollback();
                    throw;
                }
            }
        }

    }
}
