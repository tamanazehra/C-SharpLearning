//Write a C# Sharp program to convert the last 3 characters of a given string to uppercase. 
//If the length of the string is less than 3, then uppercase all the characters
//"Python"
//"Javascript"
//"js"
//"PHP"


using System.Security;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(test("Python"));
        Console.WriteLine(test("Javascript"));
        Console.WriteLine(test("js"));
        Console.WriteLine(test("PHP"));

        Console.ReadLine();
    }
    private static string test(string str)
    {
        if (str.Length < 3)
        {
            return str.ToUpper();
        }
        else
        {
            string start = str.Substring(0, str.Length - 3);
            string end = str.Substring(str.Length -3).ToUpper();

            return start + end;
        }
    }
}