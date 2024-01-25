int firstNum = int.Parse(Console.ReadLine());
int secondNum  = int.Parse(Console.ReadLine()); 
int thirdNum  = int.Parse(Console.ReadLine());  
int forthNum  = int.Parse(Console.ReadLine());

int firstOperation = 0;
int secondOperation = 0;
int thirdOperation = 0;

firstOperation = firstNum + secondNum;
secondOperation = firstOperation / thirdNum;
thirdOperation = secondOperation * forthNum;

Console.WriteLine($"{thirdOperation}");