
    internal class Program
    {
        static void Main()
        {
            int days = int.Parse(Console.ReadLine());
            int dailyPlunder = int.Parse(Console.ReadLine());
            double expectedPlunder = double.Parse(Console.ReadLine());

            double total = 0;

            for (int i = 1; i <= days; i++)
            {
                total += (double)dailyPlunder;

                if(i % 3 == 0)
                {
                    total += dailyPlunder * 0.5;
                }

                if(i % 5 == 0)
                {
                    total *= 0.7;
                }
                
            }

            if (total >= expectedPlunder)
            {
                Console.WriteLine($"Ahoy! {total:f2} plunder gained.");
            }
            else
            {
                var percentage = total / expectedPlunder * 100;
                Console.WriteLine($"Collected only {percentage:F2}% of the plunder.");
            }

        }
    }
