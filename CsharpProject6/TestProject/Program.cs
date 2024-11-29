//Practicing c# basic operations
//convert Fahrenheit to Celsius

internal class Program
{
    private static void Main(string[] args)
    {
        int fahrenheit = 97;
        decimal celsius = (fahrenheit - 32m) * (5m / 9m);

        Console.WriteLine("The tempreature is: "  + celsius + " celsius.");
    }
}