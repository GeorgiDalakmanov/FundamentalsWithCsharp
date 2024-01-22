int num = int.Parse(Console.ReadLine());
int sum = 0;

bool curentNum = false;
for (int i = 1; i <= num; i++)
{
    int value = i;
    while (i > 0)
    {
        sum += i % 10;
        i = i / 10;
    }
    if (curentNum = (sum == 5) || (sum == 7) || (sum == 11)) ;
    {
        Console.WriteLine($"{value} -> {curentNum}");
    }
    sum = 0;
    i = value;
}
