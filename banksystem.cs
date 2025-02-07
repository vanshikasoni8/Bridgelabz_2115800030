//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Xml.Schema;

//namespace _4jan
//{
//    internal class banksystem
//    {
//        private static readonly string bankName = "HDFC";
//        private static int totalAccount = 0;
//        private readonly int AccountNumber;
//        private string AccountHolderName;
//        private double balance;
//        private const double MinimumBalance = 1000;


//    }
//        public banksystem(int accountNumber, double AccountHolderName, double initialDeposit)
//        {
//            if (initialDeposit < MinimumBalance)
//            {
//                throw new ArgumentOutOfRangeException("Minimun Amout in the account should be {MinimumBalance}");
//            }
//            this.AccountNumber = accountNumber;
//            this.AccountHolderName = AccountHolderName;
//            this.balance = initialDeposit;
//            totalAccount++;
//        }

//        public static void GetTotalAccount()
//        {
//            Console.WriteLine("Total Account in the Bank : {totalAccount}");

//        }

//        public void DisplayAccountDetails()
//        {
//            Console.Write("Account Details:");
//            Console.Write("Bank Name: {bankName}");
//            Console.Write("Account Number: {AccountNumber}");
//            Console.Write("Account Holder : {AccountHolderName}");
//            Console.Write("Balance : {balance}");


//        }
//        public void deposit(double amount)
//        {
//            if (amount > 0)
//            {
//                balance += amount;
//                Console.Write("{amount} is deposited Sucessfully.");
//            }
//            else
//            {
//                Console.Write("Deposit amout must be positive");
//            }

//        }

//        public void withdraw(double amount)
//        {
//            if(amount>0 && balance-amount>= MinimumBalance)
//            {
//                balance -= amount;
//                Console.WriteLine("{amount} is withdrawal sucessfully.")
//            }
//            else
//            {
//                Console.WriteLine("Invalid withdrawal or remaining amount is less then {MinimumBalance}");
//            }
//        }

//        public static void Checkstatus()
//        {
//            Console.WriteLine(" Current balance in the acount is {balance}")
//        }

//        public static void Main()
//        {
//            Console.Write("enter bank name: ");
//            string inputBankName = Console.ReadLine();

//            //typeof(BankAccount).GetField("bankName")

//            try
//            {
//                banksystem account = new banksystem(1001, "Vanshika", 2000.0);
//                int choice;
//                do
//                {
//                    Console.Write("Welcone to {inputBankName} ");
//                    Console.WriteLine("1. Check Balance");
//                    Console.WriteLine("2. Deposit Money");
//                    Console.WriteLine("3. Withdraw Money");
//                    Console.WriteLine("4. Display Account Details");
//                    Console.WriteLine("5. Exit");
//                    Console.Write("Enter your choice: ");

//                    if(int.TryParse(Console.ReadLine(), out choice))
//                    {
//                        switch (choice)
//                        {
//                            case 1:
//                                account.Checkstatus();
//                                break;
//                            case 2:
//                                Console.Write("enter the amount");
//                                if(int.TryParse(Console.ReadLine(),out double ))
//                        }
//                    }
//                }
                
//            }
//        }

    
        



        

//}
