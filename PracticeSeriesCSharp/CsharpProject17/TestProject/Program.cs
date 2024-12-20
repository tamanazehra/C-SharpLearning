//Write a C# Sharp program to check if a string 'yt' appears at index 1 in a given string. 
//If it appears return a string without 'yt' otherwise return the original string.

// Sample Input:
// "Python"
// "ytade"
// "jsues"

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(test ("Python"));
        Console.WriteLine(test ("ytade"));
        Console.WriteLine(test ("jsues"));
        Console.WriteLine(test ("yt"));
    }
    private static string test (string s)
    {
        if (s.Length >= 3 && s.Substring(1, 2) == "yt")
        {
            return s.Substring(0, 1) + s.Substring(3);
        }
        else
        {
            return s;
        }
    }
}