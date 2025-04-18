using System;
using System.Collections.Generic;

public class Bank
{
    private List<Account> accounts;

    public Bank()
    {
        accounts = new List<Account>();
    }

    public void AddAccount(Account account)
    {
        accounts.Add(account);
    }

    public Account GetAccount(string accountNumber)
    {
        return accounts.Find(a => a.AccountNumber == accountNumber);
    }

    public void Transfer(string fromAccountNumber, string toAccountNumber, decimal amount)
    {
        var from = GetAccount(fromAccountNumber);
        var to = GetAccount(toAccountNumber);

        if (from == null || to == null)
        {
            throw new Exception("One or both accounts not found.");
        }

        from.Withdraw(amount);
        to.Deposit(amount);
    }

    public void DisplayAllAccounts()
    {
        foreach (var account in accounts)
        {
            Console.WriteLine(account);
        }
    }
}
