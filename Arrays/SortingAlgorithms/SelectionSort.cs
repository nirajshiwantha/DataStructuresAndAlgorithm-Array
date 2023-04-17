using Arrays.BasicOperations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Arrays.SortingAlgorithms
{
    public class SelectionSort
    {
        public void SelectionSortAlgo(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                // Find the minimum element in the unsorted part of the array
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                }

                // Swap the minimum element with the first element in the unsorted part of the array
                int temp = arr[minIndex];
                arr[minIndex] = arr[i];
                arr[i] = temp;
            }

            BasicArrayOperations basicOps = new BasicArrayOperations();
            basicOps.PrintArray(arr);
        }
    }
}
