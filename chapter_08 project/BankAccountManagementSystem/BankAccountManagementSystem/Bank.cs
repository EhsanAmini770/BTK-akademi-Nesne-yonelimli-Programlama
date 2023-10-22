namespace BankAccountManagementSystem
{
    public static class Bank
    {
        public static List<Account> Accounts = new List<Account>();
        public static List<string> TransactionHistory = new List<string>();

        public static void AddAccount(Account account)
        {
            Accounts.Add(account);
        }

        public static void DisplayBankInfo()
        {
            Console.WriteLine("Welcome to Our Bank!");
            Console.WriteLine($"Total number of accounts: {Accounts.Count}");
        }

        public static void TrackTransaction(string description)
        {
            TransactionHistory.Add($"{DateTime.Now:G}: {description}");
        }
    }

}
