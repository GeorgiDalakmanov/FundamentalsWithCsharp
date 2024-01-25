
class Program
{
    static void Main()
    {
        int countKeg = int.Parse(Console.ReadLine());

        string kegBiggest = "";
        double biggestKeg = 0;

        for (int i = 0; i < countKeg; i++)
        {
            string modelKeg = Console.ReadLine();
            double radiusKeg = double.Parse(Console.ReadLine());
            int heightKeg = int.Parse(Console.ReadLine());

            double volume = Math.PI * (radiusKeg * radiusKeg) * heightKeg;

            if (volume > biggestKeg)
            {
                biggestKeg = volume;
                kegBiggest = modelKeg;
            }
        }
        Console.WriteLine(kegBiggest);
    }
}
