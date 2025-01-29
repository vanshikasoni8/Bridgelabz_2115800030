/* using System;


class BMI
{
    static void Main()
    {
        // Take input for the number of persons
        Console.Write("Enter the number of persons: ");
        int numberOfPersons = int.Parse(Console.ReadLine());


        // Create arrays to store weight, height, BMI, and weight status
        double[] height = new double[numberOfPersons];
        double[] weight = new double[numberOfPersons];
        double[] bmi = new double[numberOfPersons];
        string[] status = new string[numberOfPersons];


        // Input the weight and height for each person
        for (int i = 0; i < numberOfPersons; i++)
        {
            Console.Write($"Enter height (in meters) for person {i + 1}: ");
            height[i] = double.Parse(Console.ReadLine());


            Console.Write($"Enter weight (in kilograms) for person {i + 1}: ");
            weight[i] = double.Parse(Console.ReadLine());


            // Calculate BMI for the person: BMI = weight / (height * height)
            bmi[i] = weight[i] / (height[i] * height[i]);


            // Determine the weight status based on BMI
            if (bmi[i] < 18.5)
                status[i] = "Underweight";
            else if (bmi[i] >= 18.5 && bmi[i] <= 24.9)
                status[i] = "Normal";
            else if (bmi[i] >= 25.0 && bmi[i] <= 39.9)
                status[i] = "Overweight";
            else
                status[i] = "Obese";
        }


        // Display the height, weight, BMI, and status of each person
        Console.WriteLine("\nPerson\tHeight (m)\tWeight (kg)\tBMI\t\tStatus");
        Console.WriteLine("--------------------------------------------------------");
        for (int i = 0; i < numberOfPersons; i++)
        {
            Console.WriteLine($"{i + 1}\t{height[i]:0.00}\t\t{weight[i]:0.00}\t\t{bmi[i]:0.00}\t{status[i]}");
        }
    }
}
 */