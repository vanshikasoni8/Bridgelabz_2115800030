using System;
using System.Collections.Generic;

// Abstract base class for course types
abstract class CourseType
{
    public string TypeName { get; set; }
    protected CourseType(string typeName)
    {
        TypeName = typeName;
    }
}

class ExamCourse : CourseType
{
    public ExamCourse() : base("Exam Based Course") { }
}

class AssignmentCourse : CourseType
{
    public AssignmentCourse() : base("Assignment Based Course") { }
}

// Generic Course class restricted to CourseType
class Course<T> where T : CourseType
{
    public string CourseName { get; set; }
    public int Credits { get; set; }
    public T CourseCategory { get; set; }

    public Course(string courseName, int credits, T courseCategory)
    {
        CourseName = courseName;
        Credits = credits;
        CourseCategory = courseCategory;
    }

    public void Display()
    {
        Console.WriteLine($"Course: {CourseName}, Type: {CourseCategory.TypeName}, Credits: {Credits}");
    }
}

class Program
{
    static void Main()
    {
        Course<ExamCourse> mathCourse = new Course<ExamCourse>("Mathematics", 4, new ExamCourse());
        Course<AssignmentCourse> csCourse = new Course<AssignmentCourse>("Computer Science", 3, new AssignmentCourse());

        List<Course<CourseType>> courseCatalog = new List<Course<CourseType>> { mathCourse, csCourse };

        Console.WriteLine("\nUniversity Course Catalog:");
        foreach (var course in courseCatalog)
        {
            course.Display();
        }
    }
}

