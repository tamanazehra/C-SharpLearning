//Write a C# Sharp program that prints the multiplication table of a number as input.

Console.WriteLine("Enter the Number: ");
int input = Convert.ToInt32(Console.ReadLine());
int product;
Console.WriteLine($"The Multiplication Table of {input} is - ");

for (int i = 0; i <= 10; i++)
{
    product = input * i;
    Console.WriteLine($"{input} x {i} = {product}");
}
Console.ReadLine();

