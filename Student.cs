//using System;

//public class Student
//{
//    private int RollNumber { get; set; }
//    protected string Name { get; set; }
//    private double CGPA { get; set; }

//    // Constructor
//    public Student(int rollNumber, string name, double cgpa)
//    {
//        RollNumber = rollNumber;
//        Name = name;


//        CGPA = cgpa;
//    }

//    public int GetRollNumber()
//    {
//        return RollNumber;
//    }

//    public double GetCGPA()
//    {
//        return CGPA;
//    }

//    // Public method to modify the CGPA
//    public void SetCGPA(double cgpa)
//    {
//        if (cgpa >= 0 && cgpa <= 10)
//        {
//            CGPA = cgpa;
//        }
//        else
//        {
//            Console.WriteLine("Invalid CGPA value. CGPA should be between 0 and 10.");
//        }
//    }

//    public void DisplayStudentDetails()
//    {
//        Console.WriteLine($"Roll Number: {GetRollNumber()}");
//        Console.WriteLine($"Name: {Name}");
//        Console.WriteLine($"CGPA: {CGPA}");
//    }
//}

//class PostgraduateStudent : Student
//{
//    // Constructor to initialize PostgraduateStudent details, calling base class constructor
//    public PostgraduateStudent(int rollNumber, string name, double cgpa) : base(rollNumber, name, cgpa)
//    {
//    }
//    // Method to display the name of the PostgraduateStudent
//    public void DisplayPostgraduateDetails()
//    {
//        Console.WriteLine($"Postgraduate Student Name: {Name}");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Student student1 = new Student(101, "Alice", 8.5);
//        student1.DisplayStudentDetails();

//        Console.WriteLine($"CGPA before update: {student1.GetCGPA()}");
//        student1.SetCGPA(9.2); // Modifying CGPA
//        Console.WriteLine($"CGPA after update: {student1.GetCGPA()}");

//        PostgraduateStudent pgStudent = new PostgraduateStudent(102, "Bob", 8.0);
//        pgStudent.DisplayPostgraduateDetails();

//        // Display details of PostgraduateStudent
//        pgStudent.DisplayStudentDetails();
//        Console.ReadLine();
//    }

//}
