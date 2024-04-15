// See https://aka.ms/new-console-template for more information



using System.Xml.Serialization;

Student haya = new Student("Haya", "comp", 3.4);


haya.StudentSummary();

GraduateStudent graduateStudent = new GraduateStudent("haya", "ist", 3.2, "coded");
graduateStudent.StudentSummary();

public class Student
{
    public string Name { get; set; }
    public string Major { get; set; }
    public double Gpa { get; set; }

    public Student(string name, string major, double gpa)
    {
        Name = name;
        Major = major;
        Gpa = gpa;
    }
    public void StudentSummary()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Major: {Major}");
        Console.WriteLine($"Gpa: {Gpa}");
    }
}

public class GraduateStudent : Student
{
    public string TheTopic { get; set; }
    public GraduateStudent(string name, string major, double gpa, string theTopic) : base(name, major, gpa)
    {
        TheTopic = theTopic;
    }
    public void PrintGraduateStudentSummary()
    {
        base.StudentSummary();
        Console.WriteLine($"The Topic: {TheTopic}");
    }
}


