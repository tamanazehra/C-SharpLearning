internal class Program
{
    private static void Main(string[] args)
    {
        void GeneratingRandomNumbers()
        {
            Random random = new Random();

            for (int i = 0; i < 5 ; i++)
            {
                Console.Write($"{random.Next(1, 100)} ");
            }
        }
        Console.WriteLine("Generating Random Numbers:");
        GeneratingRandomNumbers();
    }
}