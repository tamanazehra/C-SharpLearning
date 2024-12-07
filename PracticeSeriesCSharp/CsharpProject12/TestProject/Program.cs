    //Create a new string taking the first 3 characters
    // of a given string and return the string with the 3 characters added at both the front and back

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(test("Pyton"));
        Console.WriteLine(test("C#"));
        Console.WriteLine(test("JavaScript"));
        Console.WriteLine(test ("C++"));
    }
    private static string test(string str)
    {
        if(str.Length <  3)
        {
            return str + str + str;
        }
        else
        {
            var front = str.Substring(0, 3);
            return front + str + front;
        }
    }
}