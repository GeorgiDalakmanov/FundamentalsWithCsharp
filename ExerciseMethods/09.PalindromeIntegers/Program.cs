using System;
    internal class Program
    {
        static void Main()
        {
        string input;
            while ((input = Console.ReadLine()) != "END")
            {
            bool isPalindrone = IsNumberPalindrone(input);
            Console.WriteLine(isPalindrone);
        }
    }

       static bool IsNumberPalindrone(string input)
       {
        string firstHalf = input.Substring(0, input.Length / 2);
        char[] charArr = input.ToCharArray();

        Array.Reverse(charArr);

        string temp = new string(charArr);

        string lastHalf = temp.Substring(0, temp.Length/2);

        bool isEqual = firstHalf == lastHalf;

        return isEqual;
       }
    }