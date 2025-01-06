using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your Input: ");
        string input = Console.ReadLine();
        string word = "";
        Console.Write("The Decompressed Ouptput: " + word);

        foreach (char ch in input)
        {
            if (ch >= '0' && ch <= '9') 
            {
                int Count = int.Parse(ch.ToString());
                for (int i = 0; i < Count; i++)
                {
                    Console.Write(word + " "); 
                }
                word = ""; 
            }
            else
            {
                word += ch;
            }
        }
    }
}









