List<double> number = Console.ReadLine()
    .Split()
    .Select(double.Parse)
    .ToList();
for (int i = 0; i < number.Count -1; i++)
{
    double curent = number[i];
    double next = number[i + 1];

    if (curent == next)
    {
        number[i] = curent + next;
        number.Remove(next);
        i = -1;
    }
}

Console.WriteLine(string.Join(" ", number));