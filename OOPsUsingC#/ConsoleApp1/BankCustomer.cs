using System;

namespace Classes_M1;

public class BankCustomer
{
    
    public string FirstName = "Tim";
    public string LastName = "Shao";
    public readonly string CustomerId;

    public BankCustomer()
    {
        
    }

    public BankCustomer(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;

        Console.WriteLine($"BankCustomer created: {firstName} {lastName}");
    }


    public BankCustomer(string firstName, string lastName, string customerIdNumber)
    {
        FirstName = firstName;
        LastName = lastName;
        CustomerId = customerIdNumber;
    }



}
