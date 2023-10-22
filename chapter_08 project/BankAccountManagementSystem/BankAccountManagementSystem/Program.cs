using BankAccountManagementSystem;
using System;

class Program
{
    static void Main(string[] args)
    {
        Bank.DisplayBankInfo();

        // Create accounts and perform transactions
        Account account1 = new Account("12345", "John Doe", 1000.0);
        Account account2 = new Account("67890", "Jane Smith", 2000.0);

        account1.Deposit(500.0);
        account2.Withdraw(800.0);

        account1.Transfer(account2, 300.0);

        account1.Withdraw(2000.0);

        account1.ViewBalance();
        account2.ViewBalance();

        // Display transaction history
        Console.WriteLine("\nTransaction History:");
        foreach (var transaction in Bank.TransactionHistory)
        {
            Console.WriteLine(transaction);
        }
    }
}
