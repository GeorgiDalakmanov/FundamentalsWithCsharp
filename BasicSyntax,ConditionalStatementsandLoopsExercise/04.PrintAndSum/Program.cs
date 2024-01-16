using System.Security;

int a = int.Parse(Console.ReadLine());
int b  = int.Parse(Console.ReadLine());
int sum = 0;

for (int i = a; i < b; i++)
{
    Console.Write($"{i} ");
    sum += i;
}
Console.WriteLine(b);
sum += b;

Console.WriteLine($"Sum: {sum}");
