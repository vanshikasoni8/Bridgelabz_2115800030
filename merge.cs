using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sorting_14feb
{
    internal class merge
    {
    
        static void Merge(int[] prices, int left, int mid, int right)
        {
            int n1 = mid - left + 1;
            int n2 = right - mid;

            int[] leftArray = new int[n1];
            int[] rightArray = new int[n2];

            for (int i = 0; i < n1; i++)
                leftArray[i] = prices[left + i];
            for (int j = 0; j < n2; j++)
                rightArray[j] = prices[mid + 1 + j];

            int x = 0, y = 0, k = left;
            while (x < n1 && y < n2)
            {
                if (leftArray[x] <= rightArray[y])
                    prices[k++] = leftArray[x++];
                else
                    prices[k++] = rightArray[y++];
            }

            while (x < n1)
                prices[k++] = leftArray[x++];
            while (y < n2)
                prices[k++] = rightArray[y++];
        }

        static void MergeSort(int[] prices, int left, int right)
        {
            if (left < right)
            {
                int mid = left + (right - left) / 2;
                MergeSort(prices, left, mid);
                MergeSort(prices, mid + 1, right);
                Merge(prices, left, mid, right);
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
            int[] bookPrices = { 500, 150, 300, 100, 450, 200, 350 };

            Console.WriteLine("Original Book Prices:");
            PrintArray(bookPrices);

            MergeSort(bookPrices, 0, bookPrices.Length - 1);

            Console.WriteLine("Sorted Book Prices:");
            PrintArray(bookPrices);
        }
    }

}
