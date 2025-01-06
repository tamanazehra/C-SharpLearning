using System;

class Program
{
    static void Main(string[] args)
    {
        
        string input = "hello2";

        string word = ""; 

        
        for (int i = 0; i < input.Length-1; i++)
        {
                word += input[i]; 
            
        }

         int number = int.Parse(input[input.Length - 1].ToString()); 

        Console.WriteLine("Word: " + word);
        Console.WriteLine("Number: " + number);
    }
}








