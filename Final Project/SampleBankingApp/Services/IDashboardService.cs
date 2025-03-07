using SampleBankingApp.DTOs;

namespace SampleBankingApp.Services
{
    public interface IDashboardService
    {
        Task<AccountDTO> GetAccountByEmail(string email);
        Task<AccountDTO> GetAccountById(int accountId);
        Task<UserDashboardDTO> GetUserDashboard(string email);
    }
}