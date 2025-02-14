using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sorting_14feb
{
    internal class selection
    {
    
        static void SelectionSort(int[] scores)
        {
            int n = scores.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (scores[j] < scores[minIndex])
                    {
                        minIndex = j;
                    }
                }
                (scores[i], scores[minIndex]) = (scores[minIndex], scores[i]);
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
            int[] examScores = { 85, 78, 92, 67, 88, 76, 95, 89 };

            Console.WriteLine("Original Exam Scores:");
            PrintArray(examScores);

            SelectionSort(examScores);

            Console.WriteLine("Sorted Exam Scores:");
            PrintArray(examScores);
        }
    }

}
