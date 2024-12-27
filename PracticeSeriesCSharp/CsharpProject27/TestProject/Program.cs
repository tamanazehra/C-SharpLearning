//Write a C# Sharp program to create a string made of every other character starting 
//with the first in a given string.
//Sample Input:
//"Python"
//"PHP"
//"JS"
//Expected Output:
//Pto
//PP
//J

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(test("Python"));
        Console.WriteLine(test("PHP"));
        Console.WriteLine(test("JS"));
        Console.ReadLine();
    }
    private static string test(string str)
    {
        string result = "";

        for (int i = 0; i < str.Length; i += 2)
        {
            result += str[i];
        }
        return result;
    }
} 