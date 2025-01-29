using System;


class BMI
{
    static void Main()
    {
        // Take input for the number of persons
        Console.Write("Enter the number of persons: ");
        int numberOfPersons = int.Parse(Console.ReadLine());


        // Create a 2D array to store weight, height, and BMI for each person
        double[][] personData = new double[numberOfPersons][];
       
        // Create an array to store the weight status of each person
        string[] weightStatus = new string[numberOfPersons];


        // Input the weight and height for each person
        for (int i = 0; i < numberOfPersons; i++)
        {
            // Initialize the 2D array for each person
            personData[i] = new double[3];  // 0 -> height, 1 -> weight, 2 -> BMI
           
            // Input height with validation for positive value
            do
            {
                Console.Write($"Enter height (in meters) for person {i + 1}: ");
                personData[i][0] = double.Parse(Console.ReadLine());
                if (personData[i][0] <= 0)
                    Console.WriteLine("Please enter a positive value for height.");
            } while (personData[i][0] <= 0);


            // Input weight with validation for positive value
            do
            {
                Console.Write($"Enter weight (in kilograms) for person {i + 1}: ");
                personData[i][1] = double.Parse(Console.ReadLine());
                if (personData[i][1] <= 0)
                    Console.WriteLine("Please enter a positive value for weight.");
            } while (personData[i][1] <= 0);


            // Calculate BMI and store it in the array
            personData[i][2] = personData[i][1] / (personData[i][0] * personData[i][0]);


            // Determine the weight status based on BMI
            if (personData[i][2] < 18.5)
                weightStatus[i] = "Underweight";
            else if (personData[i][2] >= 18.5 && personData[i][2] <= 24.9)
                weightStatus[i] = "Normal";
            else if (personData[i][2] >= 25.0 && personData[i][2] <= 39.9)
                weightStatus[i] = "Overweight";
            else
                weightStatus[i] = "Obese";
        }


        // Display the height, weight, BMI, and status of each person
        Console.WriteLine("\nPerson\tHeight (m)\tWeight (kg)\tBMI\t\tStatus");
        Console.WriteLine("--------------------------------------------------------");
        for (int i = 0; i < numberOfPersons; i++)
        {
            Console.WriteLine($"{i + 1}\t{personData[i][0]:0.00}\t\t{personData[i][1]:0.00}\t\t{personData[i][2]:0.00}\t{weightStatus[i]}");
        }
    }
}
