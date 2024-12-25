//Write a C# Sharp program to check if the first appearance of "a" in a given string is
//immediately followed by another "a".
//Sample Input:
//"caabb"
//"babaaba"
//"aaaaa"
//Expected Output:
//True
//False
//True

internal class  Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(test("caabb"));
        Console.WriteLine(test("babaaba"));
        Console.WriteLine(test("aaaaa"));

        Console.ReadLine();
    }
    private static bool test(string str)
    { 
        for (int i = 0; i < str.Length - 1; i++)
        { 
            if (str[i] == 'a' && str[i + 1] == 'a')
            {
                return true;
            }
            else if (str[i] == 'a')
            {
                return false;
            }
        }
        return false;


    }

}
