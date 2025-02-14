using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sorting_14feb
{
    internal class count
    {
    
        static void CountingSort(int[] ages, int min, int max)
        {
            int range = max - min + 1;
            int[] count = new int[range];
            int[] output = new int[ages.Length];

            for (int i = 0; i < ages.Length; i++)
                count[ages[i] - min]++;

            for (int i = 1; i < range; i++)
                count[i] += count[i - 1];

            for (int i = ages.Length - 1; i >= 0; i--)
            {
                output[count[ages[i] - min] - 1] = ages[i];
                count[ages[i] - min]--;
            }

            for (int i = 0; i < ages.Length; i++)
                ages[i] = output[i];
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
            int[] studentAges = { 12, 15, 14, 11, 16, 10, 18, 17, 13, 12 };

            Console.WriteLine("Original Student Ages:");
            PrintArray(studentAges);

            CountingSort(studentAges, 10, 18);

            Console.WriteLine("Sorted Student Ages:");
            PrintArray(studentAges);
        }
    }

}
