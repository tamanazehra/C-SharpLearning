//Write a C# Sharp program to create a string where 'if' is added to the front of a given string.
// If the string already begins with 'if', return it unchanged.

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(test("if else"));
        Console.WriteLine(test("else"));
    }
    private static string test(string x)
    {
        if (x.Length >= 2 && x.Substring(0, 2).Equals("if"))
        {
            return x;
        }
        else
        {
            return "if " + x;
        }
    }
}