//Assignment2
//Write a C# program that sets up a basic user profile by collecting 
//name, email, and phone number using different data types.

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Enter Your Full Name: ");
        string fullName = Console.ReadLine();

        Console.Write("Enter Your Email Id: ");
        string emailId = Console.ReadLine();

        Console.Write("Enter Your Phone Number: ");
        string phoneNumber = Console.ReadLine();

        Console.WriteLine("\t\t\tUser Profile");
        Console.WriteLine($"Full Name => {fullName}");
        Console.WriteLine($"Email-ID => {emailId}");
        Console.WriteLine($"Phone Number => {phoneNumber}");

        Console.ReadLine();
    }
}
