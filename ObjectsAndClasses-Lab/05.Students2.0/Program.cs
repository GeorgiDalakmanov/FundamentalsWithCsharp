

    internal class Program
    {
        static void Main()
        {
            List<Student> students = new List<Student>();
            string line = string.Empty;
            while ((line = Console.ReadLine()) != "end")
        {
            string[] studentTokens = line.Split();
            string firstName = studentTokens[0];
            string lastName = studentTokens[1];
            string age = studentTokens[2];
            string homeTown = studentTokens[3];

            Student student = IsStudentExisting(students, firstName, lastName);

            if (student == null)
            {

                students.Add(new Student
                {
                    Firstname = firstName,
                    LastName = lastName,
                    Age = age,
                    NameTown = homeTown

                });
            }
            else
            {
                student.Age = age;
                student.NameTown = homeTown;
            }
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

    private static Student IsStudentExisting(List<Student> students, string firstName, string lastName)
    {
        Student result = null;
        foreach (Student student in students)
        {
            if (student.Firstname == firstName && student.LastName == lastName)
            {
                result = student;
            }

        }

        return result;
    }
}

    class Student
    {
        public string Firstname { get; set; }

        public string LastName { get; set; }

        public string Age { get; set; }

        public string NameTown { get; set; }

        public string GetStudenInfo
        {
            get
            {
                return $"{Firstname} {LastName} is {Age} years old.";
            }
        }
    }
