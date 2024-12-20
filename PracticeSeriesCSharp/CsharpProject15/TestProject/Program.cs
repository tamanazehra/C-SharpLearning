//Write a C# Sharp program to check whether three given integer values are in the range 20..50 inclusive.
//Return true if 1 or more of them are in the said range otherwise false.

// Sample Input:
// 11, 20, 12
// 30, 30, 17
// 25, 35, 50
// 15, 12, 8

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(test(11, 20, 12));
        Console.WriteLine(test(30, 30, 17));
        Console.WriteLine(test(15, 12, 8));
        Console.WriteLine(test(25, 35, 50));
    }

    private static bool test(int x, int y, int z)
    {
        if ((x >= 20 && x <= 50 ) || (y >= 20 && y <= 50) || (z >= 20 && z <= 50))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}