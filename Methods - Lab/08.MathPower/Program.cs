namespace _08.MathPower
{
    internal class Program
    {
        static void Main()
        {
           double num = int.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());
            
            double result = MathPower(num, power);
            Console.WriteLine(result);
        }

 static double MathPower(double num, int power)
        {
            double result = 1;
            for (int i = 0; i < power; i++)
            {
                result *= num;
                
            }
            return result;
        }
        
          
        
    }
}
