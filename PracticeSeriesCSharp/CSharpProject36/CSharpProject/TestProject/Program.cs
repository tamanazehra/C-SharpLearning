using System;

namespace BankingApplication
{
    // Abstract base class for accounts
    public abstract class Account
    {
        public string AccountNumber { get; private set; }
        public string AccountHolderName { get; private set; }
        public decimal Balance { get; protected set; }

        public Account(string accountNumber, string accountHolderName, decimal initialBalance)
        {
            AccountNumber = accountNumber;
            AccountHolderName = accountHolderName;
            Balance = initialBalance;
        }

        public abstract void Deposit(decimal amount);

        public abstract bool Withdraw(decimal amount);

        public void DisplayBalance()
        {
            Console.WriteLine($"Account Number: {AccountNumber}, Balance: {Balance:C}");
        }
    }

    // SavingsAccount class inheriting from Account
    public class SavingsAccount : Account
    {
        private const decimal MinimumBalance = 500;

        public SavingsAccount(string accountNumber, string accountHolderName, decimal initialBalance)
            : base(accountNumber, accountHolderName, initialBalance)
        {
        }

        public override void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Deposit amount must be positive.");
                return;
            }
            Balance += amount;
            Console.WriteLine($"Deposited {amount:C} to Savings Account {AccountNumber}.");
        }

        public override bool Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Withdrawal amount must be positive.");
                return false;
            }
            if (Balance - amount < MinimumBalance)
            {
                Console.WriteLine("Insufficient balance to maintain the minimum required balance.");
                return false;
            }
            Balance -= amount;
            Console.WriteLine($"Withdrew {amount:C} from Savings Account {AccountNumber}.");
            return true;
        }
    }

    // CurrentAccount class inheriting from Account
    public class CurrentAccount : Account
    {
        private const decimal OverdraftLimit = 1000;

        public CurrentAccount(string accountNumber, string accountHolderName, decimal initialBalance)
            : base(accountNumber, accountHolderName, initialBalance)
        {
        }

        public override void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Deposit amount must be positive.");
                return;
            }
            Balance += amount;
            Console.WriteLine($"Deposited {amount:C} to Current Account {AccountNumber}.");
        }

        public override bool Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Withdrawal amount must be positive.");
                return false;
            }
            if (Balance - amount < -OverdraftLimit)
            {
                Console.WriteLine("Overdraft limit exceeded.");
                return false;
            }
            Balance -= amount;
            Console.WriteLine($"Withdrew {amount:C} from Current Account {AccountNumber}.");
            return true;
        }
    }

    // Bank class to manage accounts
    public class Bank
    {
        public void SimulateTransactions()
        {
            // Create accounts
            Account savings = new SavingsAccount("SA123", "John Doe", 1000);
            Account current = new CurrentAccount("CA456", "Jane Smith", 500);

            // Perform transactions
            savings.Deposit(500);
            savings.Withdraw(800);
            savings.DisplayBalance();

            current.Deposit(1000);
            current.Withdraw(2000);
            current.DisplayBalance();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank();
            bank.SimulateTransactions();
        }
    }

    // Unit tests for the banking application
    public class BankTests
    {
        public void TestSavingsAccount()
        {
            SavingsAccount savings = new SavingsAccount("SA123", "John Doe", 1000);
            savings.Deposit(500);
            savings.Withdraw(800);
            Console.WriteLine($"Savings Account Balance: {savings.Balance:C}"); // Expected: 700
        }

        public void TestCurrentAccount()
        {
            CurrentAccount current = new CurrentAccount("CA456", "Jane Smith", 500);
            current.Deposit(1000);
            current.Withdraw(2000);
            Console.WriteLine($"Current Account Balance: {current.Balance:C}"); // Expected: -500
        }
    }
}