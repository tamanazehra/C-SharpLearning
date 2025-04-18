using System;

public abstract class Account
{
    public string AccountNumber { get; private set; }
    public decimal Balance { get; protected set; }

    public Account(string accountNumber, decimal initialBalance)
    {
        AccountNumber = accountNumber;
        Balance = initialBalance;
    }

    public abstract void Deposit(decimal amount);
    public abstract void Withdraw(decimal amount);

    public override string ToString()
    {
        return $"Account Number: {AccountNumber}, Balance: {Balance:C}";
    }
}

