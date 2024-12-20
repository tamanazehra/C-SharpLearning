//Write a C# Sharp program to check if a given string contains between 2 and 4 'z' characters.
// Sample Input:
// "frizz"
// "zane"
// "Zazz"
// "false"
// "zzzz"
// "ZZZZ"

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(test("frizz"));
        Console.WriteLine(test("zane"));
        Console.WriteLine(test("Zazz"));
        Console.WriteLine(test("false"));
        Console.WriteLine(test("zzzz"));
        Console.WriteLine(test("ZZZZ"));
    }
    private static bool test(string s)
    {
        int count = 0; 

        foreach (char c in s)
        {
            if (c == 'z')
            {
                count++;
            }
        }
         return count >= 2 && count <=4;
    }
}