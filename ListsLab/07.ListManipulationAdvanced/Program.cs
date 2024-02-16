using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> numbers = Console.ReadLine()
                                    .Split(' ')
                                    .Select(int.Parse)
                                    .ToList();

        bool listChanged = false;

        string command;
        while ((command = Console.ReadLine()) != "end")
        {
            string[] cmdArgs = command.Split(' ');

            switch (cmdArgs[0])
            {
                case "Contains":
                    int numberToCheck = int.Parse(cmdArgs[1]);
                    if (numbers.Contains(numberToCheck))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                    break;
                case "PrintEven":
                    Console.WriteLine(string.Join(" ", numbers.Where(n => n % 2 == 0)));
                    break;
                case "PrintOdd":
                    Console.WriteLine(string.Join(" ", numbers.Where(n => n % 2 != 0)));
                    break;
                case "GetSum":
                    Console.WriteLine(numbers.Sum());
                    break;
                case "Filter":
                    string condition = cmdArgs[1];
                    int filterNumber = int.Parse(cmdArgs[2]);

                    switch (condition)
                    {
                        case "<":
                            Console.WriteLine(string.Join(" ", numbers.Where(n => n < filterNumber)));
                            break;
                        case ">":
                            Console.WriteLine(string.Join(" ", numbers.Where(n => n > filterNumber)));
                            break;
                        case ">=":
                            Console.WriteLine(string.Join(" ", numbers.Where(n => n >= filterNumber)));
                            break;
                        case "<=":
                            Console.WriteLine(string.Join(" ", numbers.Where(n => n <= filterNumber)));
                            break;
                    }
                    break;
            }

        
            listChanged = true;
        }

        if (listChanged)
        {
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
