using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask13._1
{
    public class Account
    {
        private string accountName;
        private decimal balance;

        public decimal Balance => balance;

        public Account(string accountName, decimal balance)
        {
            this.accountName = accountName;
            this.balance = balance;
        }

        public void Withdrawal(decimal amountOfMoney)
        {
            if (amountOfMoney <= balance)
            {
                balance -= amountOfMoney;
            }
            else
            {
                Console.WriteLine("Transaction declined: insufficient funds.");
            }
        }
        public void Deposit(decimal amountOfMoney)
        {
            balance += amountOfMoney;
        }
    }
}
