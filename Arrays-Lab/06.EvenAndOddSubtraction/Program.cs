


class Program
        {
            static void Main(string[] args)
            {
                int[] num = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                int evenSum = 0;
                int oddSum = 0;

                for (int i = 0; i < num.Length; i++)
                {
                    int currentNum = num[i];

                    if (currentNum % 2 == 0)
                    {
                        evenSum += currentNum;

                    }
                    else
                    {
                        oddSum += currentNum;
                    }

                }
                int differentSum = evenSum - oddSum;
                Console.WriteLine(differentSum);
            }
        }

