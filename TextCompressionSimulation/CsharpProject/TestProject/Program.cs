
internal class Program
{
    private static void Main(string[] args)
    {

         string? input = Console.ReadLine();

        Console.WriteLine("Enter the String : ");
        string? input = Console.ReadLine();

            if (input == null)
                {
                    Console.WriteLine("Input cannot be null !");
                    return;
                }

        Console.WriteLine("Enter the String : ");
        string? input = Console.ReadLine();

        if (input == null)
        {
            Console.WriteLine("Input cannot be null!");
            return;
        }
        string compressed = Compress(input);
        Console.WriteLine("The Compressed Output: " + compressed);

        Console.ReadLine();
    }
    private static string Compress(string input)
    {
        string[] words = input.Split(' ');
        List<string> result = new List<string>();

        int count = 1;

        for (int i = 1; i < words.Length; i++)
        {
            if (words[i] == words[i - 1])
            {
                count++; 
            }
            else
            {
                if (count > 1)
                {
                    result.Add(words[i - 1] + count.ToString());
                }
                else
                {
                    result.Add(words[i - 1]);
                }
                count = 1; 
            }
        }
        if (count > 1)
        {
            result.Add(words[words.Length - 1] + count.ToString());
        }
        else
        {
            result.Add(words[words.Length - 1]);
        }
        return string.Join(" ", result);
    }
}
