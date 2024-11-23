using System;

internal class Program
{
    private static void Main(string[] args)
    {
        // Global variables
        int[] times = { 800, 1200, 1600, 2000 }; // Medicine timings in HHMM format
        int diff = 0; // Difference in time zones in HHMM format

        // Method to display medicine times in HH:MM format
        void DisplayMedicineTime()
        {
            foreach (int val in times)
            {
                string time = val.ToString("D4"); // Format to always have 4 digits (e.g., 0800)
                string formattedTime = time.Insert(2, ":"); // Insert ':' after the first two digits
                Console.Write($"{formattedTime} "); // Display the formatted time
            }
            Console.WriteLine(); // For a new line
        }

        // Method to adjust medicine times based on time difference
        void AdjustTime()
        {
            for (int i = 0; i < times.Length; i++)
            {
                times[i] = (times[i] + diff + 2400) % 2400; // Adjust time and ensure it stays in 24-hour format
            }
        }

        Console.WriteLine("Enter current GMT :");
        int currentGMT = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Current Medicine Schedule:");
        DisplayMedicineTime();

        Console.WriteLine("Enter new GMT ):");
        int newGMT = Convert.ToInt32(Console.ReadLine());

        // Validate GMT values
        if (Math.Abs(currentGMT) > 12 || Math.Abs(newGMT) > 12)
        {
            Console.WriteLine("Invalid GMT");
            return;
        }

        // Calculate time difference in HHMM format
        if ((newGMT >= 0 && currentGMT >= 0) || (newGMT <= 0 && currentGMT <= 0))
        {
            diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));
        }
        else
        {
            diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));
        }

        // Adjust medicine schedule
        AdjustTime();

        Console.WriteLine("New Medicine Schedule:");
        DisplayMedicineTime();
    }
}
