using SampleBankingApp.DTOs;

namespace SampleBankingApp.Services
{
    public interface ITransactionService
    {
        Task ProcessTransaction(TransactionDTO transactionDto);
    }
}