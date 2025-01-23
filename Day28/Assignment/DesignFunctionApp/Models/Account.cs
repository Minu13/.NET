using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignFunctionApp.Models
{
    class Account
    {
        //fields
        private int _id;
        private string _name;
        private double _amount;

        //Constructors
        public Account() { }
        public Account(int id, string name, double amount)
        {
            _id = id;
            _name = name;
            _amount = amount;
        }

        //Properties
       public int Id
        {
            get
            { 
            return _id;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }
        }
        public double Amount
        {
            get
            {
                return _amount;
            }
        }

        //Methods
        public void Deposit(double amount) 
        {
        }
        public void Withdraw(double amount)
        { 
        }

        public int GetMethodCount()
        {
            return 2;
        }  
        public int GetConstructorCount()
        {
            return 2;
        } 
        public int GetPropertyCount()
        {
            return 3;
        } 
    }
}
