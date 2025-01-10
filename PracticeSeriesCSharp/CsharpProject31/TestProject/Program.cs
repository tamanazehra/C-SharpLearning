//Write a C# Sharp program to swap two numbers.
internal class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the 1st Number: ");
        int input1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the 2nd Number: ");
        int input2 = Convert.ToInt32(Console.ReadLine());

        int temp;

        temp = input1;
        input1 = input2;
        input2 = temp;

        Console.WriteLine("\t\t\tAFTER  SWAPING");
        Console.WriteLine("The 1st Number: " + input1);
        Console.WriteLine("The 2nd Number: " + input2);

        Console.ReadLine();

    }
}



