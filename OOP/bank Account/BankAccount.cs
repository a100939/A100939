using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObject
{
    public class BankAccount
    {
        public string accountNumber = string.Empty;
        public double balance = 0;
        public string accountHolderName = string.Empty;
        public DateTime dateOpened = new DateTime();

        public BankAccount(string accNo, double bal, string accountholder, DateTime dateOpened)
        {
            accountNumber = accNo;
            balance = bal;
            accountHolderName = accountholder;
            this.dateOpened = dateOpened;
        }

        public void Deposit(double amount)
        {
            balance += amount;
        }

        public void Withdraw(double amount)
        {
            balance -= amount;
        }
    }
}
