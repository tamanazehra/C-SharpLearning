//Write a C# Sharp program to check which number is closest to 100 among two given integers.
//Return 0 if the two numbers are equal.

// Sample Input:
// 78, 95
// 95, 95
// 99, 70

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(test(78, 95));
        Console.WriteLine(test(95, 95));
        Console.WriteLine(test(99, 70));
    }
    private static int test(int x, int y)
    {
        int absX = Math.Abs(x - 100);
        int absY = Math.Abs(y - 100);

        if (absX == absY)
        {
            return 0;
        }
        else if(absX > absY)
        {
            return y;
        }
        else
        {
            return x;
        }
    }
}