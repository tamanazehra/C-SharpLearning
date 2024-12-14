//Write a C# Sharp program that checks whether one temperature is less than 0 and another is greater than 100.

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(test(12, -1));
        Console.WriteLine(test(-1, 120));
        Console.WriteLine(test(2, 120));
    }
    private static bool test(int temp1, int temp2)
    {
        if (temp1 < 0 && temp2 > 100 || temp1 > 100 && temp2 < 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}