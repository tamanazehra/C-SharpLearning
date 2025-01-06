using System;

class Program
{
    static void Main(string[] args)
    {
        
        string input = "hello3";

        string word = ""; 

        
        for (int i = 0; i < input.Length-1; i++)
        {
                word += input[i]; 
            
        }

         int number = int.Parse(input[input.Length - 1].ToString()); 

     

        for (int i = 1; i <= number; i++)
        {
            Console.Write(word + " ");
        }
    }
}








