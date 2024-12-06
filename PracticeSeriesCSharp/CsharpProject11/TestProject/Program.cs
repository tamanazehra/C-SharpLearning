//Write a C# Sharp program to check if a given positive number is a multiple of 3 or 7.

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(test(58));
    }
    private static string test(int i)
    {
        if (i % 7 == 0 || i %  3  == 0)
        {
            return "is multiple of 3 or 7";
        }
        else 
        {
            return "not a multiple of 3 or 7";
        }
    }
}