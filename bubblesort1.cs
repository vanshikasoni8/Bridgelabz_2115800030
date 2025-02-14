using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sorting_14feb
{
    internal class bubblesort1
    {
        static void BubbleSort(int[] marks)
        {
            int n = marks.Length;
            bool swapped;

            for (int i = 0; i < n - 1; i++)
            {
                swapped = false;
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (marks[j] > marks[j + 1])
                    {
                        // Swap elements
                        int temp = marks[j];
                        marks[j] = marks[j + 1];
                        marks[j + 1] = temp;
                        swapped = true;
                    }
                }

                // If no two elements were swapped, the array is already sorted
                if (!swapped)
                    break;
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
            int[] studentMarks = { 85, 78, 92, 67, 88, 76, 95, 89 };

            Console.WriteLine("Original Marks:");
            PrintArray(studentMarks);

            BubbleSort(studentMarks);

            Console.WriteLine("Sorted Marks:");
            PrintArray(studentMarks);
        }
    }
}
