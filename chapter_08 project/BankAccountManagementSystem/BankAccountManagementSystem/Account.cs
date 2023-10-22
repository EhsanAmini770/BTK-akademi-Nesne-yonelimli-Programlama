using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountManagementSystem
{
    public class Account
    {
        public string AccountNumber { get; }
        public string Owner { get; }
        public double Balance { get; private set; }

        public Account(string accountNumber, string owner, double balance)
        {
            AccountNumber = accountNumber;
            Owner = owner;
            Balance = balance;
            Bank.AddAccount(this);
        }

        public void Deposit(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Invalid deposit amount. Amount must be greater than zero.");
                return;
            }

            Balance += amount;
            Console.WriteLine($"Deposited {amount:C} into account {AccountNumber}. New balance: {Balance:C}");
            Bank.TrackTransaction($"{Owner} deposited {amount:C} into account {AccountNumber}.");
        }

        public void Withdraw(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Invalid withdrawal amount. Amount must be greater than zero.");
                return;
            }

            if (Balance >= amount)
            {
                Balance -= amount;
                Console.WriteLine($"Withdrawn {amount:C} from account {AccountNumber}. New balance: {Balance:C}");
                Bank.TrackTransaction($"{Owner} withdrew {amount:C} from account {AccountNumber}.");
            }
            else
            {
                Console.WriteLine($"Insufficient funds in account {AccountNumber}. Withdrawal denied.");
            }
        }

        public void Transfer(Account targetAccount, double amount)
        {
            if (targetAccount == this)
            {
                Console.WriteLine("Cannot transfer to the same account.");
                return;
            }

            if (amount <= 0)
            {
                Console.WriteLine("Invalid transfer amount. Amount must be greater than zero.");
                return;
            }

            if (Balance >= amount)
            {
                Balance -= amount;
                targetAccount.Deposit(amount);
                Console.WriteLine($"Transferred {amount:C} to account {targetAccount.AccountNumber}. New balance: {Balance:C}");
                Bank.TrackTransaction($"{Owner} transferred {amount:C} to account {targetAccount.AccountNumber}.");
            }
            else
            {
                Console.WriteLine("Insufficient funds for the transfer. Transfer denied.");
            }
        }

        public void ViewBalance()
        {
            Console.WriteLine($"Account owner: {Owner}");
            Console.WriteLine($"Account number: {AccountNumber}");
            Console.WriteLine($"Account balance: {Balance:C}");
        }
    }

}
