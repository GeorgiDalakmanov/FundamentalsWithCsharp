


namespace _05.RemoveNegativesAndReverse
{
    internal class Program
    {
        static void Main()
        {
            List<int> numbers = ReadIntegers();

            List<int> positiveNum = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] >= 0)

                {
                    positiveNum.Add(numbers[i]);
                }
            }
            if (positiveNum.Count == 0)
            {
                Console.WriteLine("empty");
                return;
            }

            positiveNum.Reverse();
            PrintResult(positiveNum);

            static List<int> ReadIntegers()
            {
                return Console.ReadLine().Split().Select(int.Parse).ToList();
            }


            static void PrintResult(List<int> number, string separator = " ")
            {
                Console.WriteLine(string.Join(separator, number));
            }

            

            
        }
    }
}
