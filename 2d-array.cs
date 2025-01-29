/* using System;


class OneDmatrix
{
    static void Main()
    {
        // Get user input for rows and columns
        Console.Write("Enter the number of rows: ");
        int rows = int.Parse(Console.ReadLine());
        Console.Write("Enter the number of columns: ");
        int columns = int.Parse(Console.ReadLine());


        // Create and populate the 2D array
        int[,] matrix = new int[rows, columns];
        Console.WriteLine("Enter the elements of the matrix:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write($"Element [{i},{j}]: ");
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }


        // Create a 1D array to store elements of the 2D array
        int[] array = new int[rows * columns];
        int index = 0;


        // Copy elements from 2D array to 1D array
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                array[index++] = matrix[i, j];
            }
        }


        // Display the 1D array
        Console.WriteLine("\nElements in the 1D array:");
        foreach (int value in array)
        {
            Console.Write(value + " ");
        }
    }
}
 */