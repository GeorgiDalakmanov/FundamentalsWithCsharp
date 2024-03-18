
internal class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

       Dictionary<string,List<string>> dic = new Dictionary<string,List<string>>();

        for (int i = 0; i < n; i++)
        {
            string word = Console.ReadLine();
            string synonym = Console.ReadLine();

            if (!dic.ContainsKey(word))
            {
                dic[word] = new List<string>();

            }
            dic[word].Add(synonym);
   
        }
        foreach (KeyValuePair<string, List<string>> kvp in dic)
        {
            Console.WriteLine($"{kvp.Key} - {string.Join(", ", kvp.Value)}");
        }
    }
}
