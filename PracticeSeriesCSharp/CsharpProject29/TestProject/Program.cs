//Write a program in C# Sharp to display the first 10 natural numbers.

internal class Program
{
    private static void Main(string[] args)
    {
       Console.WriteLine("The first 10 Natural Numbers are:");
       for (int i = 1; i <= 10; i++)
       {
        Console.Write(i + " ");
       }
    }
}