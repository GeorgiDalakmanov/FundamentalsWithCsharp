using System.ComponentModel.Design;

string day = Console.ReadLine();    
int age = int.Parse(Console.ReadLine());
int price = 0;

if (age < 0 || age > 122)
{
    Console.WriteLine("Error!");
    return;
}
if (day == "Weekday")
{
    if (age >18 && age <=64 )
    {
        Console.WriteLine("18$");
    }
    else
    {
       Console.WriteLine("12$");
    }
}

else if (day == "Weekend")
{
    if (age > 18 && age <=64 )
    {
        Console.WriteLine("20$");

    }
    else
    {
        Console.WriteLine("15$");
    }
}

else
{
    if (age > 18 && age <= 64)
    {
        Console.WriteLine("12$");
    }
    else if (age >= 0 && age <= 18)
    {
        Console.WriteLine("5$");
    }

    else
    {
        Console.WriteLine("10$");
    }
}
