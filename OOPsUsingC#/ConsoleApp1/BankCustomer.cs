using System;

namespace Classes_M1;

public class BankCustomer
{
    public BankCustomer()
    {
       Console.WriteLine("BankCustomers created."); 
    }

    
    public BankCustomer(string firstName, string lastName)
    {
        Console.WriteLine($"BankCustomer created: {firstName} {lastName}");
    }

}
