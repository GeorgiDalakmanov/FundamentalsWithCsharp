namespace _04.Students
{
    internal class Program
    {
        static void Main()
        {
            List<Student> students = new List<Student>();
            string line = string.Empty;
            while ((line = Console.ReadLine()) != "end") 
            {
                string[] studentTokens = line.Split();
                Student student = new Student()
                {
                    Firstname = studentTokens[0],
                    LastName = studentTokens[1],
                    Age = int.Parse(studentTokens[2]),
                    NameTown = studentTokens[3],
                };

                students.Add(student);                
            }

            string filter = Console.ReadLine();

            foreach (Student student in students)
            {
                if (student.NameTown == filter)
                {
                    Console.WriteLine(student.GetStudenInfo);
                }
            }
        }
        
    }

    class Student
    {
        public string Firstname { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public string NameTown { get; set; }

        public string GetStudenInfo 
        { 
            get
            {
                return $"{Firstname} {LastName} is {Age} years old.";
            }
        }
    }
}
