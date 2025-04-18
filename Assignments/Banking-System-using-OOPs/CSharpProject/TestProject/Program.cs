using System;

public class Program
{
    public static void Main()
    {
        Bank bank = new Bank();

        var savings = new SavingsAccount("SA123", 1000m);
        var checking = new CheckingAccount("CA456", 500m);

        bank.AddAccount(savings);
        bank.AddAccount(checking);

        Console.WriteLine("Initial Accounts:");
        bank.DisplayAllAccounts();

        Console.WriteLine("\nDepositing $200 to Savings...");
        savings.Deposit(200);

        Console.WriteLine("Withdrawing $100 from Checking...");
        checking.Withdraw(100);

        Console.WriteLine("\nAfter Transactions:");
        bank.DisplayAllAccounts();

        Console.WriteLine("\nTransferring $300 from Savings to Checking...");
        bank.Transfer("SA123", "CA456", 300);

        Console.WriteLine("\nFinal Account States:");
        bank.DisplayAllAccounts();

        Console.ReadLine();
    }
}


