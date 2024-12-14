
//Write a C# Sharp program to check two given integers whether either of them is in the range 
//100..200 inclusive.

// Sample Input:
// 100, 199
// 250, 300
// 105, 190

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(test(100, 199));
        Console.WriteLine(test(250, 300));
        Console.WriteLine(test(105, 190));
    }
    private static bool test(int x, int y)
    {
        if ((x >= 100 && x <= 200) || (y >= 100 && y <= 200))
        {
            return true;
        }
        else
        {
            return false;
        }

    }
}