//Write a C# Sharp program to create a string with the last char added at the front and back 
//of a given string of length 1 or more.

internal class Program
{
    private static void Main(string[] args)
    {
      Console.WriteLine(test("yellow"));
      Console.WriteLine(test("green"));
      Console.WriteLine(test("blue"));
    }
    private static string test(string color)
    {
       var s = color.Substring(color.Length - 1);
       return s + color + s;
    }
}