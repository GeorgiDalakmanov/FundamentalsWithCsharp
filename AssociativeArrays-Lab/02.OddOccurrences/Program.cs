internal class Program
{
    static void Main()
    {
        string[] word = Console.ReadLine()
            .Split()
            .Select(x => x.ToLower())
            .ToArray();
        Dictionary<string, int> counts = new Dictionary<string, int>();

      foreach (var item in word)
        {
            
            if (!counts.ContainsKey(item))
            {
                counts[item] = 0;

            }
            counts[item]++;
        }

      foreach (var  kvp in counts)
        {
            if (kvp.Value % 2 == 1)
            {
                Console.Write($"{kvp.Key} ");
            }
        }
    }
 }

