internal class Program
{
    private static void Main(string[] args)
    {
        int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9, };
        Console.WriteLine("Contents of array:");
        PrintArray();

        void PrintArray()
        {
            foreach (int num in a)
            {
                Console.Write($"{num}");
            }
            Console.WriteLine();
        }
    }
}