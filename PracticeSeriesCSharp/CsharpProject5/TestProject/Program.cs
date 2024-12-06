//Write a C# Sharp program to check a given integer and return true if it is within 10 of 100 or 200.


internal class Program
{
    private static void Main(string[] args)
    {

    Console.WriteLine(test(104));
    Console.WriteLine(test(90));
    Console.WriteLine(test(83));

    }
    private static bool test(int x)
    {
        if (x >= 90 && x <= 110)
        {
            return true;
        }
        else if (x >= 190 && x <= 200)
        {
            return true;
        }
        else 
        {
            return false;
        }
    }
}