
    internal class Program
    {
        static void Main(string[] args)
        {
        int n = int.Parse(Console.ReadLine());

        int[] number = new int[n];
        for (int i = 0; i < number.Length; i++)
        {
            number[i] = int.Parse(Console.ReadLine());
        }
        string result = "";
        for (int i = number.Length - 1; i >= 0; i--)
        {
            result += $"{number[i]} ";

        }
        Console.WriteLine(result);
        }
    }
