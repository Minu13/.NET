using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountPolymorphism.Models
{
    abstract class Account
    {
        private string _id;
        private string _name;
        protected double _balance;

        public Account(string id,string name,double balance) 
        { 
        _balance = balance;
            _id = id;
            _name = name;
        }
        public string Id { get { return _id; } }
        public string Name { get { return _name; } }
        public double Balance { get { return _balance; } }

        public void Deposit(double amount)
        {
            _balance += amount;
        }

        public abstract void Withdraw(double amount);

        public abstract string type {  get; }

    }
}
