internal class Program
{
    static void Main()
    {
        double num1 = double.Parse(Console.ReadLine());
        char letter = char.Parse(Console.ReadLine());
        double num2 = double.Parse(Console.ReadLine());

        double result = Calculate(num1, letter, num2);
        Console.WriteLine(result);
    }

    static double Calculate(double num1, char letter, double num2)
    {
        double result = 0;

        switch (letter)
        {
            case '+':
                result = num1 + num2;
                break;
            case '-':
                result = num1 - num2;
                break;
            case '*':
                result = num1 * num2;
                break;
            case '/':

                if (num2 != 0)
                    result = num1 / num2;
                    
                break;
        }

        return result;
    }
}