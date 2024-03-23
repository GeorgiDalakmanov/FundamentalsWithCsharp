
 internal class Program
 {
     static void Main()
     {

        Dictionary<string, uint> resourseMap = new Dictionary<string, uint>();

        string input;
        while ((input = Console.ReadLine()) != "stop")
        {
            string resourse = input;
            uint quantity = uint.Parse(Console.ReadLine());

            if (!resourseMap.ContainsKey(resourse))
            {
                resourseMap.Add(resourse, 0);
            }

            resourseMap[resourse] += quantity;
        }
        //kvp - keyVakuePair
        foreach (var kvp in resourseMap)
        {
            Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
        }
         
     }
 }

