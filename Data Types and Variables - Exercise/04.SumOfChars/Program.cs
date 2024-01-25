using System;
    internal class Program
    {
        static void Main()
        {
            int linesCount = int.Parse(Console.ReadLine());
            
            int totalSum = 0;
            
            for (int i = 0; i < linesCount; i++) 
            {
                char c =char.Parse(Console.ReadLine());
                totalSum += c;
            }
            
            
               Console.WriteLine($"The sum equals: {totalSum}");
        }
    }
