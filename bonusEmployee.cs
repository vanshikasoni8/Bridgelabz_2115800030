/* using System;


class bonusEmployee
{
    static void Main()
    {
        // Define the number of employees
        const int numEmployees = 10;


        // Define arrays to store employee data
        double[] salary = new double[numEmployees];
        double[] yearsOfService = new double[numEmployees];
        double[] newSalary = new double[numEmployees];
        double[] bonus = new double[numEmployees];


        // Variables to store total amounts
        double totalBonus = 0;
        double totalOldSalary = 0;
        double totalNewSalary = 0;


        // Input loop for employee salary and years of service
        for (int i = 0; i < numEmployees; i++)
        {
            bool validInput = false;


            while (!validInput)
            {
                Console.WriteLine($"Enter details for Employee {i + 1}:");


                // Input salary
                Console.Write("Enter salary: ");
                string salaryInput = Console.ReadLine();
                bool isSalaryValid = double.TryParse(salaryInput, out salary[i]);


                // Input years of service
                Console.Write("Enter years of service: ");
                string serviceInput = Console.ReadLine();
                bool isServiceValid = double.TryParse(serviceInput, out yearsOfService[i]);


                // Check if both salary and years of service are valid
                if (isSalaryValid && isServiceValid && salary[i] > 0 && yearsOfService[i] >= 0)
                {
                    validInput = true; // Valid input, break the loop
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter valid salary and years of service.");
                    i--; // Decrement index to re-enter the details for the current employee
                }
            }
        }


        // Calculate bonus and new salary, and accumulate totals
        for (int i = 0; i < numEmployees; i++)
        {
            // Calculate bonus based on years of service
            if (yearsOfService[i] > 5)
            {
                bonus[i] = salary[i] * 0.05; // 5% bonus
            }
            else
            {
                bonus[i] = salary[i] * 0.02; // 2% bonus
            }


            // Calculate new salary after bonus
            newSalary[i] = salary[i] + bonus[i];


            // Accumulate totals
            totalBonus += bonus[i];
            totalOldSalary += salary[i];
            totalNewSalary += newSalary[i];
        }


        // Output results
        Console.WriteLine("\nEmployee Bonus and Salary Information:");
        for (int i = 0; i < numEmployees; i++)
        {
            Console.WriteLine($"Employee {i + 1}:");
            Console.WriteLine($"Old Salary: {salary[i]:C}");
            Console.WriteLine($"Bonus: {bonus[i]:C}");
            Console.WriteLine($"New Salary: {newSalary[i]:C}");
            Console.WriteLine();
        }


        // Output the total amounts
        Console.WriteLine($"Total Bonus Payout: {totalBonus:C}");
        Console.WriteLine($"Total Old Salary: {totalOldSalary:C}");
        Console.WriteLine($"Total New Salary: {totalNewSalary:C}");
    }
}
 */