
//using System;

//class BankAccount
//{

//    public string AccountNumber { get; set; }
//    protected string AccountHolder { get; set; }
//    private decimal Balance { get; set; }

//    // Constructor to initialize BankAccount details
//    public BankAccount(string accountNumber, string accountHolder, decimal balance)
//    {
//        AccountNumber = accountNumber;
//        AccountHolder = accountHolder;
//        Balance = balance;
//    }

//    public decimal GetBalance() => Balance;
//    public void SetBalance(decimal amount) => Balance = amount;

//    public void DisplayAccountDetails()
//    {
//        Console.WriteLine($"Account Number: {AccountNumber}");
//        Console.WriteLine($"Account Holder: {AccountHolder}");
//        Console.WriteLine($"Balance: ${Balance}");
//    }
//}

//class SavingsAccount : BankAccount
//{
//    // Constructor to initialize SavingsAccount details
//    public SavingsAccount(string accountNumber, string accountHolder, decimal balance)
//        : base(accountNumber, accountHolder, balance) { }

//    public void DisplaySavingsAccountDetails()
//    {
//        Console.WriteLine($"Savings Account Number: {AccountNumber}");
//        Console.WriteLine($"Account Holder: {AccountHolder}");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        // Create a BankAccount instance
//        BankAccount account1 = new BankAccount("1234567890", "Alice", 1000);
//        account1.DisplayAccountDetails();

//        // Modify and display balance
//        account1.SetBalance(1200);
//        Console.WriteLine($"Updated Balance: ${account1.GetBalance()}");

//        // Create a SavingsAccount 
//        SavingsAccount savings1 = new SavingsAccount("9876543210", "Bob", 5000);
//        savings1.DisplaySavingsAccountDetails();
//        savings1.DisplayAccountDetails();
//        Console.ReadLine();
//    }
//}

