using System.Numerics;

int n = int.Parse(Console.ReadLine());

int snowballSnow = 0;
int snowballTime = 0;
int snowballQuality = 0;

BigInteger value = 0;

for (int i = 0; i < n; i++)
{
    int snow = int.Parse((Console.ReadLine()));
    int time = int.Parse((Console.ReadLine()));
    int quality = int.Parse((Console.ReadLine()));

    BigInteger snowValue = BigInteger.Pow(snow / time, quality);

    if (value < snowValue)
    {
        value = snowValue;
        snowballSnow = snow;
        snowballTime = time;
        snowballQuality = quality;
    }
}
Console.WriteLine($"{snowballSnow} : {snowballTime} = {value} ({snowballQuality})");