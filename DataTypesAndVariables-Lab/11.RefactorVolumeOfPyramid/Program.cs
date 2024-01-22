
double length = double.Parse(Console.ReadLine());
double width = double.Parse(Console.ReadLine());
double heigth = double.Parse(Console.ReadLine());

heigth = (length * width * heigth) / 3;
Console.WriteLine($"Length: Width: Height: Pyramid Volume: {heigth:f2}");
