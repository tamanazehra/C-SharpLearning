//Advanced Text Analyzer
//Write a C# program that acts as a basic text analyzer.
//* It should Accept user input. Allow the user to enter a string (paragraph or text).
//* Analyze and report statistics:
    //Count the total number of words (consider spaces as word separators).
    //Calculate the average word length. [Hint.Average word length = Summation of all letters in each word / Total number of words]

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter Your Paragragh/Text: ");
        string input = Console.ReadLine();


        string[] words = input.Split(new char[] {' ', '\t', '\n'}, StringSplitOptions.RemoveEmptyEntries);

        int totalWords = words.Length;

        int totalLetters = 0;

        foreach (string word in words)
        {
            totalLetters += word.Length;
        }

        double avgWordLength = (double)totalLetters / totalWords;

        Console.WriteLine("\t\t Text Analysis Result:");
        Console.WriteLine("Total Number of Words: " + totalWords);
        Console.WriteLine("Average Word Length: " + avgWordLength.ToString("F2"));

        Console.ReadLine();

    }
}



