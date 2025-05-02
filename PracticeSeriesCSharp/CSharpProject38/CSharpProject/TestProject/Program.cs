class Program
{
    static void Main()
    {
        string input = "Programming with C#";
        string word = input.ToLower();

        int vowelCount = 0;
        int consonentCount = 0;

        foreach (char c in word)
        {
            if (char.IsLetter(c))
            {
                if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                {
                    vowelCount++;
                }
                else
                {
                    consonentCount++;
                }
            }
        }
        Console.WriteLine($"Vowels: {vowelCount}");
        Console.WriteLine($"Consonents: {consonentCount}");
        Console.ReadLine();
    } 
}