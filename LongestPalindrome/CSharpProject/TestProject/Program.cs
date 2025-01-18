//Check the longest plaindrome in the sentence
//input = "madam speaks malayalam"
//output = "malayalam"



internal class Program
{
    static void Main(string[] args)
    {
        string input = "madam speaks malayalam";

        string output = isLongestPalindrome(input);

        Console.WriteLine("The longest palindrome is: " + output);

        Console.ReadLine();

    }

    static bool isPalindrome(string word)
    {
        string result = "";

        for (int i = word.Length - 1; i >= 0; i--)
        {
            result += word[i];
        }

        return result == word;
    }

    static string isLongestPalindrome(string input)
    {
        string[] words = input.Split(' ');
        string longest = " ";

        foreach (string word in words)
        {
            if (isPalindrome(word) && word.Length > longest.Length)
            {
                longest = word;
            }
        }
        return longest;
    }
}
