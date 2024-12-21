//Write a C# Sharp program to check if two given non-negative integers have the same last digit
//Sample Input:
// 123, 456
// 12, 512
// 7, 87
// 12, 45

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(test(123, 456));
        Console.WriteLine(test(12, 512));
        Console.WriteLine(test(7, 87));
        Console.WriteLine(test(12, 45));
    }
    private static bool test(int x, int y)
    {
        
        int absX = x % 10; // when divided by 10 remainder always returns the last digit of the number
        int absY = y % 10;

        if (absX == absY)
        {
            return true;
        }
        else {
            return false;
        }
    }
}