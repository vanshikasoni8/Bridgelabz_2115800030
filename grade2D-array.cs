using System;


class student
{
    static void Main()
    {
        // Take input for the number of students
        Console.Write("Enter the number of students: ");
        int numberOfStudents = int.Parse(Console.ReadLine());


        // Create a 2D array to store marks for Physics, Chemistry, and Maths
        double[,] marks = new double[numberOfStudents, 3]; // [student, subject]
        double[] percentages = new double[numberOfStudents];
        string[] grades = new string[numberOfStudents];


        // Input marks for students in Physics, Chemistry, and Maths
        for (int i = 0; i < numberOfStudents; i++)
        {
            Console.WriteLine($"\nEnter marks for Student {i + 1}:");


            // Input marks for Physics (index 0)
            do
            {
                Console.Write("Physics: ");
                marks[i, 0] = double.Parse(Console.ReadLine());
                if (marks[i, 0] < 0)
                    Console.WriteLine("Marks cannot be negative. Please enter positive marks.");
            } while (marks[i, 0] < 0);


            // Input marks for Chemistry (index 1)
            do
            {
                Console.Write("Chemistry: ");
                marks[i, 1] = double.Parse(Console.ReadLine());
                if (marks[i, 1] < 0)
                    Console.WriteLine("Marks cannot be negative. Please enter positive marks.");
            } while (marks[i, 1] < 0);


            // Input marks for Maths (index 2)
            do
            {
                Console.Write("Maths: ");
                marks[i, 2] = double.Parse(Console.ReadLine());
                if (marks[i, 2] < 0)
                    Console.WriteLine("Marks cannot be negative. Please enter positive marks.");
            } while (marks[i, 2] < 0);


            // Calculate the percentage for the student
            double totalMarks = marks[i, 0] + marks[i, 1] + marks[i, 2];
            percentages[i] = (totalMarks / 300) * 100;


            // Determine the grade based on the percentage
            if (percentages[i] >= 80)
                grades[i] = "A";
            else if (percentages[i] >= 70)
                grades[i] = "B";
            else if (percentages[i] >= 60)
                grades[i] = "C";
            else if (percentages[i] >= 50)
                grades[i] = "D";
            else if (percentages[i] >= 40)
                grades[i] = "E";
            else
                grades[i] = "R"; // Remedial standards
        }


        // Display the marks, percentages, and grades for each student
        Console.WriteLine("\nStudent\tPhysics\tChemistry\tMaths\tPercentage\tGrade");
        Console.WriteLine("---------------------------------------------------------------");
        for (int i = 0; i < numberOfStudents; i++)
        {
            Console.WriteLine($"{i + 1}\t{marks[i, 0]:0.00}\t\t{marks[i, 1]:0.00}\t\t{marks[i, 2]:0.00}\t{percentages[i]:0.00}%\t\t{grades[i]}");
        }
    }
}
