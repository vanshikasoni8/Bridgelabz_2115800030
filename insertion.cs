using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sorting_14feb
{
    internal class insertion
    {
 
        static void InsertionSort(int[] employeeIDs)
        {
            int n = employeeIDs.Length;
            for (int i = 1; i < n; i++)
            {
                int key = employeeIDs[i];
                int j = i - 1;

                while (j >= 0 && employeeIDs[j] > key)
                {
                    employeeIDs[j + 1] = employeeIDs[j];
                    j--;
                }
                employeeIDs[j + 1] = key;
            }
        }

        static void PrintArray(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        static void Main()
        {
            int[] employeeIDs = { 1023, 1001, 1045, 1012, 1037, 1008 };

            Console.WriteLine("Original Employee IDs:");
            PrintArray(employeeIDs);

            InsertionSort(employeeIDs);

            Console.WriteLine("Sorted Employee IDs:");
            PrintArray(employeeIDs);
        }
    }

}
