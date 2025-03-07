namespace SampleBankingApp.DTOs
{
    public class UserDashboardDTO
    {
        public string AccountNumber { get; set; }
        public string FullName { get; set; }
        public string AccountType { get; set; }
        public decimal Balance { get; set; }
        public string Status { get; set; }
        public List<TransactionDTO> Transactions { get; set; } = new List<TransactionDTO>();
    }
}
