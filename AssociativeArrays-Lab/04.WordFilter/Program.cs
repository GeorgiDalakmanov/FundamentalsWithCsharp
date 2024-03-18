

internal class Program
 {
     static void Main()
     {
        Console.WriteLine(string.Join(Environment.NewLine,
            Console.ReadLine()
            .Split()
            .Where(s => s.Length % 2 == 0)
            .ToArray()));
     }
 }

