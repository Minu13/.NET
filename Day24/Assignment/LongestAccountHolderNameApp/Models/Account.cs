

namespace LogestAccountHolderNameApp.Models
{
    class Account
    {
        private string _accountholderName;
        private double _balance;

        public Account(string accountholderName, double balance)
        {
            _accountholderName = accountholderName;
            _balance = balance;
        }

        public string AccountHolderName
        {
            get { return _accountholderName; }
        }

        public double Balance
        {
            get { return _balance; }
        }
    }
}