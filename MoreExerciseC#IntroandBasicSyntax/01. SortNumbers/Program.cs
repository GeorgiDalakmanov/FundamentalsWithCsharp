double num1, num2, num3;

if (double.TryParse(Console.ReadLine(), out num1))
{
    if (double.TryParse(Console.ReadLine(), out num2))
    {
        if (double.TryParse(Console.ReadLine(), out num3))
        {

            double[] sortedNumbers = { num1, num2, num3 };
            sortedNumbers = sortedNumbers.OrderByDescending(x => x).ToArray();

            foreach (double num in sortedNumbers)
            {
                Console.WriteLine(num);
            }
        }
      
    }
}
      
    