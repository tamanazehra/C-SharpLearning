//Write a C# program to check the sum of the two given integers. 
//Return true if one of the integers is 20 or if their sum is 20.


internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Enter the 1st Integer: ");
        int input1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the 2nd Integer: ");
        int input2 = Convert.ToInt32(Console.ReadLine());

        if (input1 == 20 || input2 == 20 || input1 + input2 == 20)
        {
            Console.WriteLine(true);
        }
        else 
        {
            Console.WriteLine(false);
        }
        Console.ReadLine();
    }
}