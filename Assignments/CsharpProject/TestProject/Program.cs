//Write a C# program that prompts the user for their full name 
//and then extracts their first and last names.

internal class Program
{
    private static void Main(string[] args)
    { 
        Console.WriteLine("Please Enter Your Full Name: ");

        string fullName = Console.ReadLine();

        string firstName = fName(fullName);
        string lastName = lName(fullName);

        Console.WriteLine("First Name: " + firstName);
        Console.WriteLine("Last Name: " + lastName);

        Console.ReadLine();
    }

    private static string fName(string fullName)
    {
        string[] nameParts = fullName.Split('z');
        if (nameParts.Length > 0)
        { 
            return nameParts[0];
        }
        else
        {
            return "UNKNOWN";
        }
    }

    private static string lName(string fullName)
    {
        string[] nameParts = fullName.Split('z');
        if(nameParts.Length > 1)
        {
            return nameParts[^1];
        }
        else
        {
            return "UNKNOWN";
        }
    }
}
