using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObject
{
    class Program
    {
        static void Main(string[] args)
        {

            BankAccount[] accounts = new BankAccount[5];
            int count = 0;

            int menuOption = 0;

            do
            {

                Console.WriteLine("Choose one of the following: \n1. Open Account\n2. Deposit\n3. Withdraw" +
                    "\n4. Query Balance\n5. Exit");

                menuOption = Convert.ToInt32(Console.ReadLine());

                switch (menuOption)
                {
                    case 1:
                        if (count < 5)
                        {
                            accounts[count] = OpenAccount();
                            count++;
                        }
                        else
                        {
                            Console.WriteLine("I'm Sorry we reached the limit");
                        }

                        break;
                    case 2:
                        {
                            int pos = SelectAccounts(accounts, count);

                            Console.Write("Deposit Amount: ");
                            double deposit = Convert.ToDouble(Console.ReadLine());

                            accounts[pos].Deposit(deposit);

                            break;
                        }
                    case 3:
                        {
                            int pos = SelectAccounts(accounts, count);

                            Console.Write("Withrawal Amount: ");
                            double withdraw = Convert.ToDouble(Console.ReadLine());

                            accounts[pos].Withdraw(withdraw);
                            break;
                        }
                    case 4:
                        {
                            int pos = SelectAccounts(accounts, count);
                            ShowAccountInfo(accounts[pos]);
                            break;
                        }

                    default :
                        Console.WriteLine("Wrong Option");
                        break;

                }//switch menuOption

            } while (menuOption != 5);


        }//main

        public static BankAccount OpenAccount()
        {
            Console.Write("Enter Account number: ");
            string acctNo = Console.ReadLine();

            Console.Write("Enter Balance: ");
            double balance = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Account Holder: ");
            string holder = Console.ReadLine();

            BankAccount ba = new BankAccount(acctNo, balance, holder, DateTime.Now);
            return ba;
        }

        public static int SelectAccounts(BankAccount[] accts, int cnt)
        {
            
            for(int i = 0; i < cnt; i++)
            {
                Console.WriteLine((i + 1) + ". " + accts[i].accountNumber);
            }
            Console.Write("Choose an account: ");
            int option = Convert.ToInt32(Console.ReadLine());

            return (option-1);

        }

        public static void ShowAccountInfo(BankAccount acct)
        {
            Console.WriteLine("Account Number: {0}\nBalance: {1}\nHolder: {2},\nDate Opened: {3}", 
                acct.accountNumber, acct.balance, acct.accountHolderName, acct.dateOpened);
        }

    }
}
