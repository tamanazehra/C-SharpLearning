//Write a C# Sharp program to create a string which is 4 copies of the 2 front characters of a given string.
// If the given string length is less than 2 return the original string.


internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(test("C Sharp"));
        Console.WriteLine(test("JavaScript"));
        Console.WriteLine(test("HTML"));
        Console.WriteLine(test("Python"));
    }
    private static string test(string s)
    {
        if (s.Length < 2)
        {
            return s;
        }
        else
        {
            return s.Substring(0, 2) + s.Substring(0, 2) + s.Substring(0, 2) + s.Substring(0, 2);
        }
    }
}