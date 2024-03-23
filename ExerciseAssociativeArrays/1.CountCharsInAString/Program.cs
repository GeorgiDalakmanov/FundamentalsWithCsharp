
using System.ComponentModel;

internal class Program
{
    static void Main()
    {
        Dictionary< char,uint> occurrences = new Dictionary< char, uint>();

        string input = Console.ReadLine();

        for (int i = 0; i < input.Length; i++)
        {
            char character = input[i];

            if(character == ' ')
            {
                continue;
            }

            if(!occurrences.ContainsKey(character))
            {
                occurrences.Add(character, 0);
            }

            occurrences[character]++;
        }

        foreach (KeyValuePair<char, uint> charPair in occurrences)
        {
            char character = charPair.Key;
            uint value = charPair.Value;
            Console.WriteLine($"{character} -> {value}");
        }
        
    }
}

