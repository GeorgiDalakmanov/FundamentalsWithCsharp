
    internal class Program
    {
        static void Main()
        {
        int number = int.Parse(Console.ReadLine());
        int sum = 0, reminder;

        while (number > 0)
        {
            reminder = number % 10;
            sum = sum + reminder;
            number = number / 10;
        }

             Console.WriteLine(sum);
       

         }
    }

