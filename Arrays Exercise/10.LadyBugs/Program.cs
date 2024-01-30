
using System.Diagnostics.SymbolStore;

class Program
    {
        static void Main(string[] args)
        {
             int  filedLenght =  int.Parse(Console.ReadLine());

            int[] bugPlace = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] filed = new int[filedLenght];

            for (int i = 0; i < bugPlace.Length; i++)
            {
                int currentIndex = bugPlace[i];
                
                if (currentIndex >= 0 && currentIndex < filed.Length)
                {
                    filed[currentIndex] = 1;
                }
            }
            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] arguments = command.Split();
                int  bufIndex = int.Parse(arguments[0]);
                string direction = arguments[1];
                int flyLenght = int.Parse(arguments[2]);

                if (bufIndex < 0 || bufIndex > filed.Length - 1 || filed[bufIndex]==0 )
                {
                    continue;
                }

                filed[bufIndex] = 0;

                if (direction == "right")
                {
                    int landIndex = bufIndex + flyLenght;

                    if (landIndex > filed.Length - 1)
                    {
                        continue;
                    }

                    if (filed[landIndex] == 1)
                    {
                        while (filed[landIndex] == 1)
                        {
                            landIndex += flyLenght;
                            if (landIndex > filed.Length - 1 )
                            {
                                break;
                            }
                        }
                    }

                    if (landIndex <= filed.Length - 1)
                    {
                        filed[landIndex] = 1;
                    }
                }
                else  if (direction == "left")
                {
                    int landIndex = bufIndex - flyLenght;

                    if (landIndex < 0)
                    {
                        continue;
                    }

                    if (filed[landIndex] == 1)
                    {
                        while (filed[landIndex] == 1)
                        {
                            landIndex -= flyLenght;

                            if (landIndex < 0)
                            {
                                break;
                            }
                        }
                    }

                    if (landIndex >= 0)
                    {
                        filed[landIndex] = 1;
                    }
                }

            }

                Console.WriteLine(string.Join(" ", filed));
         }
    }