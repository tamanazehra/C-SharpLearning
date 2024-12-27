//Write a C# Sharp program to create a string like "aababcabcd" from a given string "abcd".
//Sample Input:
//"abcd"
//"abc"
//"a"
//Expected Output:
//aababcabcd
//aababc
//a

internal class Program
{
    private static void Main (string[] args)
    {
        Console.WriteLine(test("abcd"));
        Console.WriteLine(test("abc"));
        Console.WriteLine(test("a"));

        Console.ReadLine();
    }

    private static string test(string str)
    {
        string result = "";

        for(int i = 1; i <= str.Length; i++)
        {
            result += str.Substring(0, i);
        }
        return result;
    }
}
