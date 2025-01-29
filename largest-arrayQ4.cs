/* using System;


class maxDigit
{
    static void Main()
    {
        // Define a variable to store the number
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());


        // Maximum number of digits to store in the array initially
        int maxDigits = 10;


        // Array to store the digits of the number
        int[] digits = new int[maxDigits];
        int index = 0;


        // Loop to extract digits from the number and store them in the array
        while (number != 0)
        {
            // If the index reaches maxDigits, resize the array
            if (index == maxDigits)
            {
                // Increase maxDigits by 10
                maxDigits += 10;


                // Create a new array to hold more digits
                int[] temp = new int[maxDigits];


                // Copy the contents of the current digits array to temp
                for (int i = 0; i < digits.Length; i++)
                {
                    temp[i] = digits[i];
                }


                // Assign the temp array to digits
                digits = temp;
            }


            // Get the last digit and store it in the digits array
            digits[index] = number % 10;
            number /= 10; // Remove the last digit
            index++;
        }


        // Variables to store the largest and second largest digits
        int largest = -1;
        int secondLargest = -1;


        // Loop through the array to find the largest and second largest digits
        for (int i = 0; i < index; i++)
        {
            if (digits[i] > largest)
            {
                secondLargest = largest; // Update second largest
                largest = digits[i]; // Update largest
            }
            else if (digits[i] > secondLargest && digits[i] != largest)
            {
                secondLargest = digits[i]; // Update second largest
            }
        }


        // Output the largest and second largest digits
        Console.WriteLine($"The largest digit is: {largest}");
        Console.WriteLine($"The second largest digit is: {secondLargest}");
    }
}
 */