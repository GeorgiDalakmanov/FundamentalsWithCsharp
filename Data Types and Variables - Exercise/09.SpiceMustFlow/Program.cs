int count = int.Parse(Console.ReadLine());
int days = 0;
int spice = 0; 

while (count >= 100)
{
    days++;
    spice += count;
    spice -= 26;
    count -= 10;

}
spice -= 26;
if (spice < 0)
{
    spice = 0;
}

Console.WriteLine(days);
Console.WriteLine(spice);