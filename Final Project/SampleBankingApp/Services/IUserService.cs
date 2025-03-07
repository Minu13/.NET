using SampleBankingApp.DTOs;

namespace SampleBankingApp.Services
{
    public interface IUserService
    {
        bool RegisterUser(RegisterDTO user);
        bool ValidateUser(string email, string passwordHash);
        UserDTO GetUserByEmail(string email);
    }
}