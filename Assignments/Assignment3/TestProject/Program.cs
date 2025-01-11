//Text Manipulation Challenge  
//Write a C# program that modifies a given string by:
// 1) Removing leading and trailing whitespace characters.
// 2) Converting the entire string to uppercase or lowercase (User's Choice)
// 3) Extracting a specified substring based on user input (start and end indicies)

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write(" Enter Your String: ");
        string input = Console.ReadLine();

        string trimmedInput = input.Trim();
        Console.WriteLine(" String after removing leading &\n trailing whiltespace characters: " + trimmedInput);

        Console.Write(" Enter 1 to Convert the string to Upper-Case & 2 to Lower-Case: ");
        int choice = int.Parse(Console.ReadLine());

        string upperCase = trimmedInput.ToUpper();
        string lowerCase = trimmedInput.ToLower();

        if (choice == 1)
        {
            Console.WriteLine(" Converted to Upper-Case: " + upperCase);
        }
        else if (choice == 2) 
        {
            Console.WriteLine(" Converted to Lower-Case: " + lowerCase);
        }
        else
        {
            Console.WriteLine(" Not A Valid Input ");
        }

        Console.Write(" Enter starting index of the Substring you want to extract: ");
        int startIndex = int.Parse((Console.ReadLine()));

        Console.Write(" Enter ending index of the Substring you want to extract: ");
        int endIndex = int.Parse((Console.ReadLine()));

        if (startIndex >= 0 && endIndex < trimmedInput.Length && startIndex <= endIndex)
        {
            string substring = trimmedInput.Substring(startIndex, endIndex - startIndex + 1);

            Console.WriteLine(" The Extracted Substring: " + substring);
        }
        else
        {
            Console.WriteLine(" Invalid Indicies (Please ensure that indicies are in the range of Start Index <= End Index)");
        }

        Console.ReadLine();

    }
}