//Write a C# Sharp program to get the absolute difference between n and 51. 
// If n is broader than 51 return triple the absolute difference.

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(testProgram(53));
        Console.WriteLine(testProgram(30));
        Console.WriteLine(testProgram(51));
}
    public static int testProgram(int x)
    {
        if (x > 51)
        {
            return (x - 51) * 3;
        }
        else
        {
            return (51 - x);
        }
        
    }
}