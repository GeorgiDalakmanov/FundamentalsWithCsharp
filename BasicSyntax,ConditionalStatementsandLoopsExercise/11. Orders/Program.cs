﻿int ordersCount = int.Parse(Console.ReadLine());
double totalPrice = 0;


for (int i = 0; i < ordersCount; i++)
{
    double capsulePrice = double.Parse(Console.ReadLine());
    int days = int.Parse(Console.ReadLine());
    int capsulesCount = int.Parse(Console.ReadLine());

    double price = (days * capsulesCount) * capsulePrice;
    totalPrice += price;
    Console.WriteLine($"The price for the coffee is: ${price:F2}");
}

Console.WriteLine($"Total: ${totalPrice:F2}");
Console.WriteLine("Hello, World!");
