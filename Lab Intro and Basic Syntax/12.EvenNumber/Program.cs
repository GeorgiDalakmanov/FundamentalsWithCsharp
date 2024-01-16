
        do
        {
            if (int.TryParse(Console.ReadLine(), out int number))
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine($"The number is: {Math.Abs(number)}");
                    return;
                }
                else
                {
                    Console.WriteLine("Please write an even number.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }

        } 
while (true);