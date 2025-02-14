using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sorting_14feb
{
    internal class quick
    {
    
        static void QuickSort(int[] prices, int low, int high)
        {
            if (low < high)
            {
                int pivotIndex = Partition(prices, low, high);
                QuickSort(prices, low, pivotIndex - 1);
                QuickSort(prices, pivotIndex + 1, high);
            }
        }

        static int Partition(int[] prices, int low, int high)
        {
            int pivot = prices[high];
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (prices[j] < pivot)
                {
                    i++;
                    (prices[i], prices[j]) = (prices[j], prices[i]);
                }
            }
            (prices[i + 1], prices[high]) = (prices[high], prices[i + 1]);
            return i + 1;
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
            int[] productPrices = { 500, 150, 300, 100, 450, 200, 350 };

            Console.WriteLine("Original Product Prices:");
            PrintArray(productPrices);

            QuickSort(productPrices, 0, productPrices.Length - 1);

            Console.WriteLine("Sorted Product Prices:");
            PrintArray(productPrices);
        }
    }

}
