//Write a C# Sharp program to exchange the first and
// last characters in a given string and return the new string.

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(swapChar("hello"));
        Console.WriteLine(swapChar("abcd"));
        Console.WriteLine(swapChar("yoyoyo"));  
    }
    private static string swapChar(string s)
    {
        if(s.Length <= 1)
        {
            return s;
        }
        else
        {
            char first = s[0];
            char last = s[s.Length - 1];

            return last + s.Substring(1, s.Length - 2) + first;
        }
    }
}