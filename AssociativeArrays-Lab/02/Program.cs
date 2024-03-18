namespace _02_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var result = Console.ReadLine()
                .Split()
                .Select(x => x.ToLower())
                .GroupBy(x => x)
                .Where(x => x.Count() % 2 == 1)
                .SelectMany(x => x)
                .Distinct()
                .ToList();

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
