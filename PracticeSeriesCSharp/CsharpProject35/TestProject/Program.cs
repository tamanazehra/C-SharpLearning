//Write a C# program to print odd numbers from 1 to 99. Prints one number per line.

internal class Program
{
    static void Main(string[] args)
    {
    
        for (int i = 1; i < 100; i += 2)
        {
            Console.Write(i + " ");
        }
        Console.ReadLine(); 
    }
}
