//Write a C# Sharp program to check whether two given integer values are in the range 20..50 inclusive.
// Return true if one or other is in the range, otherwise false.

// Sample Input:
// 20, 84
// 14, 50
// 11, 55
// 25, 40

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(test(20, 84));
        Console.WriteLine(test(14, 50));
        Console.WriteLine(test(11, 55));
        Console.WriteLine(test(25, 40));
    }

    private static bool test(int x ,int y)
    {
        if ((x >= 20 && x <= 50) || (y >= 20 && y <= 50))
        {
            return true;
        }
        else 
        {
            return false;
        }
    }
}