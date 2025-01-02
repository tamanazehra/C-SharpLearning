//Write a C# Sharp program to display the cube of an integer up to given number.

using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Cubes of integers from 1 to {num}:");
        for (int i = 1; i <= num; i++)
        {
            Console.WriteLine($"Cube of {i} is {cubeOfInt(i)}");
        }
    }

    private static int cubeOfInt(int i)
    {
        return i * i * i;
    }
}
