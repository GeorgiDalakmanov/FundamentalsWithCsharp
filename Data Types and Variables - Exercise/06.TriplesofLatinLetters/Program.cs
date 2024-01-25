
using System.Security.Cryptography;

internal class Program
    {
        static void Main()
        {
        int letterCount= int.Parse(Console.ReadLine());
        int startChar = 'a';
        int endChar = startChar + letterCount;

        for (int first = startChar; first < endChar ; first++)
        {
            for(int second = startChar; second < endChar; second++)
            {
                for (int third = startChar; third <endChar ; third++)
                {
                    Console.WriteLine($"{(char)first} {(char)second} {(char)third}");
                }
            }

        }
        }
    }
