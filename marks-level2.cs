/* using System;

class MarksGradeCalculator
{
    static void Main()
    {
        Console.Write("Enter marks for Physics: ");
        int physics = int.Parse(Console.ReadLine());

        Console.Write("Enter marks for Chemistry: ");
        int chemistry = int.Parse(Console.ReadLine());

        Console.Write("Enter marks for Maths: ");
        int maths = int.Parse(Console.ReadLine());

        
        // Calculate percentage
        int total = physics + chemistry + maths;
        double percentage = total / 3.0;

        // Determine grade
        string grade;
        if (percentage >= 80){
            grade = "A";
            Console.WriteLine($"Level 4 , above agency-normalized standards");
		}
        else if (percentage >= 70){
            grade = "B";
            Console.WriteLine($"Level 3 , at agency-normalized standards");
		}
        else if (percentage >= 60){
			
            grade = "C";
            Console.WriteLine($"Level 2 , below, but approaching agency-normalized standards");
		}
		
        else if (percentage >= 50){
            grade = "D";
            Console.WriteLine($"Level 1 , well below agency-normalized standards");
		}
        else if (percentage >= 40){
            grade = "E";
            Console.WriteLine($"Level 1- , too below agency-normalized standards");
		}
        else{
            grade = "R";
            Console.WriteLine($"Remedial standards");
		}

        // Output results
        
        Console.WriteLine($"Percentage: {percentage:F2}%");
        Console.WriteLine($"Grade: {grade}");
    }
}
 */