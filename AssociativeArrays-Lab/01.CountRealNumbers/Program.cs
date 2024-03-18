
using System.Runtime.Serialization.Formatters;

internal class Program
{
        static void Main()
        {
        double[] input = Console.ReadLine()
            .Split()
            .Select(double.Parse)
            .ToArray();
           SortedDictionary<double,int> numbers = new SortedDictionary<double,int>();
        for (int i = 0; i < input.Length; i++)
        {
            double currentNumber = input[i];
            if (!numbers.ContainsKey(currentNumber))
            {
                numbers.Add(currentNumber, 0);
               
            }
            numbers[currentNumber]++;
        }

        foreach(KeyValuePair<double,int> kvp in numbers)
        {
            Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
        }
    }
}

