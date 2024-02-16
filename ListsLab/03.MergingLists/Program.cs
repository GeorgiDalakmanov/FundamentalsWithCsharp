using System.Globalization;

namespace _03.MergingLists
{
    internal class Program
    {
        static void Main()
        {
            List<int> first = ReadListIntegers();
            List<int> second = ReadListIntegers();

            List<int> result = new List<int>();
            int maxCount = Math.Max(first.Count, second.Count);

            for (int i = 0; i < maxCount; i++)
            {
                if ( i < first.Count )
                {
                    result.Add(first[i]);
                }
                if (i < second.Count)
                {
                    result.Add(second[i]);
                }
            }
            PrintResult(" ", result);

        }

        static List<int> ReadListIntegers()
        {
           return Console.ReadLine().Split().Select(int.Parse).ToList();
        }

        static void PrintResult(string separator, List<int> number)
        {
            Console.WriteLine(string.Join(separator, number));
        }
    }
}
