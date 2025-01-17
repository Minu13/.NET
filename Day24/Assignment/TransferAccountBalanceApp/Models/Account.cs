
namespace TransferAccountBalanceApp.Models
{
    class Account
    {
        private readonly int _accountNumber;
        private readonly string _name;
        private double _balance;
        
        public Account(int accountNumber, string name, double balance)
        {
            _accountNumber = accountNumber;
            _name = name;
            _balance = balance;
        }

        public double Balance
        {
            get { return _balance; }
        }

        public string Name
        {
            get { return _name; }
        }

        public int AccountNumber
        {
            get { return _accountNumber; }
        }

        public bool Deposit(double amount)
        {
            if (amount > 0)
            {
                _balance += amount;
                return true;
            }
            return false;
        }

        public bool Withdraw(double amount)
        {
            if (amount > 0 && amount <= _balance)
            {
                _balance -= amount;
                return true;
            }
            return false;
        }
    }
}
