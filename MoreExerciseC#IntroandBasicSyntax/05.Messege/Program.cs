using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the digits separated by spaces:");
        string[] inputDigits = Console.ReadLine().Split();

        string result = ConvertDigitsToText(inputDigits);

        Console.WriteLine("Output: " + result);
    }

    static string ConvertDigitsToText(string[] inputDigits)
    {
        string result = "";

        foreach (string digits in inputDigits)
        {
            int mainDigit = int.Parse(digits[0].ToString());
            int digitLength = digits.Length;

            int offset = (mainDigit - 2) * 3;

            if (mainDigit == 8 || mainDigit == 9)
            {
                offset += 1;
            }

            int letterIndex = (offset + digitLength - 1) % 26;
            char letter = (char)(letterIndex + 97);

            result += letter;
        }

        return result;
    }
}