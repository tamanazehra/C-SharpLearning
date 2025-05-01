using System;

class Program
{
    static void Main()
    {
        string input = "abcd";

        
        if (input.Length < 2)
        {
            Console.WriteLine("Input string is too short to swap characters.");
        }
        else
        {
            char firstCharacter = input[0];
            char lastCharacter = input[input.Length - 1];
            string middlePart = input.Substring(1, input.Length - 2);

            string result = lastCharacter + middlePart + firstCharacter;
            Console.WriteLine(result);

            Console.ReadLine();
        }   
    }
}
