
using System.Xml;

internal class Program
    {
    static void Main()
    {
        string[] days = {
                     "Monday",
                     "Tuesday",
                    "Wednesday",
                    "Thursday",
                    "Friday",
                    "Saturday",
                    "Sunday",
            };
   int n = int.Parse(Console.ReadLine());

        if (n < 1 || n > 7)
        {
            Console.WriteLine("Invalid day! ");
            return;
        }
        else
        {
            Console.WriteLine(days[n - 1]);
        }

    }
    }
