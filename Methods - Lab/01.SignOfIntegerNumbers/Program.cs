
internal class Program
{

    static void Main()
    {

        int n = int.Parse(Console.ReadLine());
        PrintNumber(n);
    }

    static void PrintNumber(int number)
    {
        if (number == 0)
        {
            Console.WriteLine($"The number {number} is zero.");
        }
        else if (number > 0)
        {
            Console.WriteLine($"The number {number} is positive.");
        }
        else
        {
            Console.WriteLine($"The number {number} is negative.");
        }
    }
}
