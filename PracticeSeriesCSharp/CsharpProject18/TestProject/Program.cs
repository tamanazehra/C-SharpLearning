// Write a C# Sharp program to check the largest number among three given integers.
// Sample Input:
// 1,2,3
// 1,3,2
// 1,1,1
// 1,2,2

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(test(1, 2, 3));
        Console.WriteLine(test(1, 3, 2));
        Console.WriteLine(test(1, 1, 1));
        Console.WriteLine(test(1, 2, 1));
    }
    private static int test(int x, int y, int z)
    {
        if(x > y && x > z)
        {
            return x;
        }
        else if(y > x && y > z)
        {
            return y;
        }
        else
        {
            return z;
        }
    }
}