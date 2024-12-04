//Write a C# Sharp program to check two given integers, 
//and return true if one of them is 30 or if their sum is 30.

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(testProgram(30, 0));
        Console.WriteLine(testProgram(25, 5));
        Console.WriteLine(testProgram(20, 30));
        Console.WriteLine(testProgram(20, 25));
}
    private static bool testProgram(int x, int y)
    {
        if(x == 30 || y == 30 || x + y == 30)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}