namespace _06.ListManipulationBasics
{
    internal class Program
    {
        static void Main()
        {
            List<int> number = ReadListIntegers();
            string line = string.Empty;

            while ((line = Console.ReadLine()) != "end")
            {
                string[] tokens = line.Split();
                string command = tokens[0];

                if (command == "Add")
                {
                    number.Add(int.Parse(tokens[1]));
                }
                else if (command == "Remove")
                {
                    number.Remove(int.Parse(tokens[1]));

                }
                else if (command == "Insert")
                {
                    int index = int.Parse(tokens[2]);
                    int numbers = int.Parse(tokens[1]);
                    number.Insert(index, numbers);

                }
                else
                {
                    int index = int.Parse(tokens[1]);
                    number.RemoveAt(index);
                }
            }
            PrintResult(number);
        }

        static void PrintResult(List<int> numbers, string separator = (" "))
        {
            Console.WriteLine(string.Join(separator, numbers));
        }

        static List<int> ReadListIntegers()
        {
            return Console.ReadLine().Split().Select(int.Parse).ToList();
        }
    }
}
