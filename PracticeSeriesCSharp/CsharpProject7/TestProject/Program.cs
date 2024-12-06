//Write a C# Sharp program to remove the character at a given position in the string.
// The given position will be in the range 0..(string length -1) inclusive.


internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(test("Python", 1));
        Console.WriteLine(test("Python", 5));
        Console.WriteLine(test("Python", 0));
    }
    private static string test(string s , int i)
    {
        return s.Remove(i, 1);
    }       
}