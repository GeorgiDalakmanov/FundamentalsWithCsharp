using System.Linq;
double[] numbers = Console.ReadLine()
    .Split()
    .Select(double.Parse)
    .ToArray();

int[] roundedNum = new int[numbers.Length];

for (int i = 0; i < numbers.Length; i++)
{
    roundedNum[i] = (int)Math.Round(numbers[i], MidpointRounding.AwayFromZero);
}

for (int i = 0;i < numbers.Length; i++)
{
    Console.WriteLine($"{numbers[i]} => {roundedNum[i]}");
}
