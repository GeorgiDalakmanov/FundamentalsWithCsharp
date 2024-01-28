namespace _04.ReverseArrayOfStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] value = (Console.ReadLine().Split(" "));

            //for (int i = 0; i < value.length; i++)
            //{
            //    string firstelement = value[i];
            //    string lastelement = value[value.length -1 -i];

            //    value[i] = lastelement;
            //    value[value.length - 1 - i] = firstelement;

            //}
            Array.Reverse(value);
            Console.WriteLine(string.Join(" ",value));
        }
    }
}
