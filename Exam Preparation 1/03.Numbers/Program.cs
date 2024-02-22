using System;

class Program
{
    static void Main()
    {
        // Read input sequence of intege
        string input = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("No numbers provided.");
            return;
        }

        string[] parts = input.Split(' ');
        int[] numbers = new int[parts.Length];
        for (int i = 0; i < parts.Length; i++)
        {
            if (int.TryParse(parts[i], out numbers[i]) == false)
            {
                Console.WriteLine($"Invalid input: '{parts[i]}' is not a valid integer.");
                return;
            }
        }

        // Calculate the average value of the sequence
        double sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }
        double average = sum / numbers.Length;

        // Find numbers greater than the average
        int[] greaterThanAverage = new int[5];
        int count = 0;
        foreach (int num in numbers)
        {
            if (num > average)
            {
                greaterThanAverage[count] = num;
                count++;
                if (count >= greaterThanAverage.Length)
                    break;
            }
        }

        // Sort the greaterThanAverage array
        Array.Sort(greaterThanAverage, (a, b) => b.CompareTo(a));

        // Print the top 5 numbers or "No" if no numbers satisfy the condition
        if (count > 0)
        {
            Console.WriteLine("Top 5 numbers greater than average:");
            for (int i = 0; i < count; i++)
            {
                Console.Write(greaterThanAverage[i] + " ");
            }
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("No numbers greater than average.");
        }
    }
}
