//Write a C# Sharp program to compute the sum of the two numerical values
//If the two values are the same, return triple their sum.


internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(testProgram(1, 2));
        Console.WriteLine(testProgram(2, 3));
        Console.WriteLine(testProgram(2, 2));
        Console.ReadLine();
}

public static int testProgram(int x,int y)
{
   if (x == y)
   {
    return (x + y) * 3;
   }
   else 
   {
     return x + y ;
   }
}
}