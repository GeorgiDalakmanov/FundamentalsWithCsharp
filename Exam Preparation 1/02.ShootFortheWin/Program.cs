
internal class Program
{
    static void Main()
    {
        List<int> number = Console.ReadLine()
         .Split(" ")
         .Select(int.Parse)
         .ToList();

        string input;
        int shotedTargs = 0;

        while ((input = Console.ReadLine()) != "End")
        {
            int targetIndex = int.Parse(input);
            if (targetIndex < 0 || targetIndex >= number.Count)
            {
                continue;
            }

            int targetValue = number[targetIndex];
            number[targetIndex] = -1;
            shotedTargs++;

            for (int i = 0; i < number.Count; i++)
            {
                if (number[i] == -1)
                {
                    continue;

                }
                else if (number[i] > targetValue)
                {
                    number[i] -= targetValue;
                }
                else if (number[i] <= targetValue)
                {
                    number[i] += targetValue;
                }
            }

        }
        Console.WriteLine($"Shot targets: {shotedTargs} -> {string.Join(" ", number)}");
    }

}

