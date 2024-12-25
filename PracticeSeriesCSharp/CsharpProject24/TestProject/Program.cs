//Write a C# Sharp program to create a string that is n (non-negative integer) 
//copies of the first 3 characters of a given string. If the given string is shorter than 3,
// return n copies of the string.

//Sample Input:
//"Python", 2
//"Python", 3
//"JS", 3

//Expected Output:
//PytPyt
//PytPytPyt
//JSJSJS
 

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(test("Python", 2));
        Console.WriteLine(test("Python", 3));
        Console.WriteLine(test("JS", 3));

        Console.ReadLine();
    }
    private static string test(string str, int num)
    {
        string result = "";
        string subStr;
        if (str.Length > 3)
        {
            subStr = str.Substring(0, 3);
        }
        else
        {
            subStr = str;
        }

        for (int i = 0; i < num; i++)
        {
            result += subStr;
        }
        return result;

        

    }
}

