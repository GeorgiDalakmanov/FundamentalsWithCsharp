using System;
using System.Security;



class Program
{
    static void Main(string[] args)
    {
        int[] num = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

        int sum = 0;

        for (int i = 0; i < num.Length; i++)
        {
            int currentNum = num[i];

            if (currentNum % 2 == 0)
            {
                sum += currentNum;

            }
        }
                Console.WriteLine(sum);
    }
}
   

