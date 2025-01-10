//Write a C# program that removes a specified character from a non-empty string 
//using the index of a character.

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter your String: ");
        string word = Console.ReadLine();

        Console.WriteLine("Enter the index of the charecter to be removed: ");
        int index = Convert.ToInt32(Console.ReadLine());

        string output = word.Remove(index, 1);
        Console.WriteLine(output);
        Console.ReadLine();
    }
    
}
