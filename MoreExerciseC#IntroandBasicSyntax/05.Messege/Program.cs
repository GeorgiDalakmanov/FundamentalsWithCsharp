int letterCount = int.Parse(Console.ReadLine());

string smsText = "";
for (int i = 0; i < letterCount; i++)
{
    string line = Console.ReadLine();

    int clickCount = line.Length;
    char digitChar = line[0];

    switch (digitChar)
    {
        case '0':
            smsText += ' ';
            break;
        case '2':
            smsText += (char)(96 + clickCount);
            break;
        case '3':
            smsText += (char)(99 + clickCount);
            break;
        case '4':
            smsText += (char)(102 + clickCount);
            break;
        case '5':
            smsText += (char)(105 + clickCount);
            break;
        case '6':
            smsText += (char)(108 + clickCount);
            break;
        case '7':
            smsText += (char)(111 + clickCount);
            break;
        case '8':
            smsText += (char)(115 + clickCount);
            break;
        case '9':
            smsText += (char)(118 + clickCount);
            break;
    }
}
Console.WriteLine(smsText);
