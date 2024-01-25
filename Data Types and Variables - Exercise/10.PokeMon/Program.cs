using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());

        ulong pokeCount = 0;
        double precent = n * 0.5d;

        while (n >= m)
        {
            pokeCount++;
            n -= m;
            if (n == precent && y != 0)
            {
                n /= y;
            }
        

        }
        Console.WriteLine(n);
        Console.WriteLine(pokeCount);



    }
}
