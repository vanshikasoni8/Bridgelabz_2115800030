//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace _2feb
//{
//    internal class Course
//    {
//        private static string InstituteName;

//        // Instance variables for course name, duration, and fee
//        public string CourseName { get; set; }
//        public int Duration { get; set; }  // Duration in hours
//        public decimal Fee { get; set; }

//        // Constructor
//        public Course(string courseName, int duration, decimal fee)
//        {
//            CourseName = courseName;
//            Duration = duration;
//            Fee = fee;
//        }

//        public void DisplayCourseDetails()
//        {
//            Console.WriteLine($"Course Name: {CourseName}");
//            Console.WriteLine($"Duration: {Duration} hours");
//            Console.WriteLine($"Fee: ${Fee}");
//            Console.WriteLine($"Institute: {InstituteName}");
//        }

//        // Class method to update the institute name for all courses
//        public static void UpdateInstituteName(string newInstituteName)
//        {
//            InstituteName = newInstituteName;
//            Console.WriteLine($"Institute name updated to: {InstituteName}\n");
//        }
//    }

//    class Program
//    {
//        static void Main()
//        {
//            Console.Write("Enter Institute Name: ");
//            string instituteName = Console.ReadLine();
//            Course.UpdateInstituteName(instituteName);

//            Console.Write("Enter number of courses: ");
//            int numberOfCourses = int.Parse(Console.ReadLine());

//            Course[] courses = new Course[numberOfCourses];

//            for (int i = 0; i < numberOfCourses; i++)
//            {
//                Console.WriteLine($"\nEnter details for Course {i + 1}:");
//                Console.Write("Course Name: ");
//                string courseName = Console.ReadLine();

//                Console.Write("Duration (in hours): ");
//                int duration = int.Parse(Console.ReadLine());

//                Console.Write("Fee: $");
//                decimal fee = decimal.Parse(Console.ReadLine());

//                courses[i] = new Course(courseName, duration, fee);
//            }

//            Console.WriteLine("\nCourse Details:");
//            foreach (var course in courses)
//            {
//                course.DisplayCourseDetails();
//                Console.WriteLine();
//            }
//        }
//    }
//}
