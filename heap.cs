using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sorting_14feb
{
    internal class heap
    {
    
        static void HeapSort(int[] salaries)
        {
            int n = salaries.Length;

            for (int i = n / 2 - 1; i >= 0; i--)
                Heapify(salaries, n, i);

            for (int i = n - 1; i > 0; i--)
            {
                (salaries[0], salaries[i]) = (salaries[i], salaries[0]);
                Heapify(salaries, i, 0);
            }
        }

        static void Heapify(int[] salaries, int n, int i)
        {
            int largest = i;
            int left = 2 * i + 1;
            int right = 2 * i + 2;

            if (left < n && salaries[left] > salaries[largest])
                largest = left;

            if (right < n && salaries[right] > salaries[largest])
                largest = right;

            if (largest != i)
            {
                (salaries[i], salaries[largest]) = (salaries[largest], salaries[i]);
                Heapify(salaries, n, largest);
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
            int[] salaryDemands = { 55000, 75000, 60000, 50000, 80000, 72000 };

            Console.WriteLine("Original Salary Demands:");
            PrintArray(salaryDemands);

            HeapSort(salaryDemands);

            Console.WriteLine("Sorted Salary Demands:");
            PrintArray(salaryDemands);
        }
    }

}
