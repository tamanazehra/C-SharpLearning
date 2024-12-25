//Write a C# Sharp program to count the string "aa" in a given string and assume "aaa" contains two "aa".
//Sample Input:
//"bbaaccaag"
//"jjkiaaasew"
//"JSaaakoiaa"
//Expected Output:
//2
//1
//2

internal class Program
{
    private static void Main (string[] args)
    {
        Console.WriteLine(test("bbaaccaag"));
        Console.WriteLine(test("jjkiaaasew"));
        Console.WriteLine(test("JSaaakoiaa"));

        Console.ReadLine();
    }
    private static int test(string str)
    {
        int count = 0;
        for (int i = 0; i < str.Length - 1; i++)
        { 
            if (str.Substring(i, 2) == "aa")
            {
                count++;
            }
        }
        return count;
    }
}