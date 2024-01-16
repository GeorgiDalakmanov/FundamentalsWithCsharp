
using System.Security.Cryptography;

internal class Program
    {
        static void Main()
        { 
           string username = Console.ReadLine();
        char[] charArray = username.ToCharArray();
        Array.Reverse(charArray);
        string password = new string(charArray);

        int attemp = 4;
        while (attemp >0)
        {
            string typedPass = Console.ReadLine();
            attemp--;
            if (typedPass == password)
            {
                Console.WriteLine($"User {username} logged in.");
                break;
            }
            else
            {
                if ( attemp == 0)
                {
                    Console.WriteLine($"User {username} blocked!");
                }
                else
                {
                    Console.WriteLine("Incorrect password. Try again.");
                }
            }
  
        }
        }
    }
