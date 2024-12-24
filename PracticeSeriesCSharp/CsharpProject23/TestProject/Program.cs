//Write a C# Sharp program to create a string which is n (non-negative integer) copies of a given string.

//Sample Input:
//"JS", 2
//"JS", 3
//"JS", 1
//Expected Output:
//JSJS
//JSJSJS
//JS

internal class Program
{
   private static void Main(string[] args)
    {
        Console.WriteLine(test("JS", 2));
        Console.WriteLine(test("JS", 1));
        Console.WriteLine(test("JS", 3));

        Console.ReadLine();
    }

    private static string test(string str, int num)
    {
        string result = " ";
        for (int i = 0; i < num; i++)
        {
            result += str;
        }
        return result;
    }


}
