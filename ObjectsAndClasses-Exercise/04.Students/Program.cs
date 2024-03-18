
using System.Security.Cryptography.X509Certificates;

internal class Program
{
    static void Main()
    {
        List<Student> students = new List<Student>();
        int count = int.Parse(Console.ReadLine());

        for (int i = 0; i < count; i++)
        {
            string[] studentAsString = Console.ReadLine().Split();

            Student newStudent = new Student(studentAsString[0],
            studentAsString[1],
            double.Parse(studentAsString[2]));

            students.Add(newStudent);

        }

        var ordaredStudents = students
            .OrderByDescending(s => s.Grade)
            .ToList();

        foreach (Student student in ordaredStudents)
        {
            Console.WriteLine(student.GetString());
        }
    }
}


internal class Student
{
    public string FirstName { get; set; }

    public string LastName { get; set; }

    public double Grade { get; set; }


    public Student(string firstName, string lastName, double grade)
    {
        FirstName = firstName;
        LastName = lastName;
        Grade = grade;
    }
    public string GetString()
    {
        return $"{FirstName} {LastName}: {Grade:f2}";
    }
}