public class CheckingAccount : Account
{
    public CheckingAccount(string accountNumber, decimal initialBalance)
        : base(accountNumber, initialBalance) { }

    public override void Deposit(decimal amount)
    {
        Balance += amount;
    }

    public override void Withdraw(decimal amount)
    {
        if (Balance >= amount)
            Balance -= amount;
        else
            throw new Exception("Insufficient balance in checking account.");
    }
}

