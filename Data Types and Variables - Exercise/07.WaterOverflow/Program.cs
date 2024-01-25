
using System;
using System.ComponentModel.Design;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

         double sumLiters = 0;

        for (int i = 0; i < n; i++)
        {

            int qualitty = int.Parse(Console.ReadLine());
            
        

            if (sumLiters + qualitty > byte.MaxValue)
            {
                Console.WriteLine("Insifficient capacity!");
            }

            else
            {
                sumLiters += qualitty;
            }
            
        }
        Console.WriteLine(sumLiters);
    }
}
