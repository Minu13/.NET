namespace SampleBankingApp.DTOs
{
    public class AccountDTO
    {
        public int AccountId { get; set; }
        public string AccountNumber { get; set; }
        public string AccountType { get; set; }
        public decimal Balance { get; set; }
    }
}
