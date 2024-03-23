
internal class Program
{
    internal class Course
    {
        public Course(string name)
        {
            Name = name;
            StudentNames = new List<string>();
        }
        public string Name { get; set; }

        public List<string> StudentNames { get; set; }

        public override string ToString()
        {
            string result = $"{Name}: {StudentNames.Count}\n";

            for (int i = 0; i < StudentNames.Count; i++)
            {
                result += $"-- {StudentNames[i]}\n";
            }

            return result.Trim();
        }
    }
    static void Main()
    {
        Dictionary<string, Course> coursesMap = new Dictionary<string, Course>();

        string input;
        while ((input = Console.ReadLine()) != "end")
        {
            string[] args = input.Split(" : ");

            string courseName = args[0];
            string studenNmae = args[1];

            if (!coursesMap.ContainsKey(courseName))
            {
                Course newCourse = new Course(courseName);
                coursesMap.Add(courseName, newCourse);
            }

            coursesMap[courseName].StudentNames.Add(studenNmae);
        }

        foreach (var course in coursesMap.Values)
        {
            Console.WriteLine(course);
        }
    }
}

