using Arrays.BasicOperations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays.SortingAlgorithms
{
    public class QuickSort
    {
        // Sorts an array using Quick Sort algorithm
        public void QuickSortAlgo(int[] arr, int low, int high)
        {
            if (arr == null || arr.Length == 0) // Check if the array is empty or null
            {
                return;
            }

            QuickSortHelper(arr, low, high); // Call the helper function to sort the subarray between low and high

            BasicArrayOperations basicOps = new BasicArrayOperations();
            basicOps.PrintArray(arr);
        }

        private static void QuickSortHelper(int[] arr, int low, int high)
        {
            if (low < high) // Check if there are at least two elements in the subarray
            {
                int pivotIndex = Partition(arr, low, high); // Get the index of the pivot element

                QuickSortHelper(arr, low, pivotIndex - 1); // Recursively sort the elements to the left of the pivot
                QuickSortHelper(arr, pivotIndex + 1, high); // Recursively sort the elements to the right of the pivot
            }
        }

        private static int Partition(int[] arr, int low, int high)
        {
            int pivot = arr[high]; // Choose the rightmost element as the pivot
            int i = low - 1; // Initialize the index for elements less than the pivot

            for (int j = low; j < high; j++) // Loop through the subarray
            {
                if (arr[j] < pivot) // If the current element is less than the pivot
                {
                    i++; // Increment the index for elements less than the pivot
                    Swap(arr, i, j); // Swap the current element with the element at the index for elements less than the pivot
                }
            }

            Swap(arr, i + 1, high); // Swap the pivot element with the element at the index for elements less than the pivot + 1
            return i + 1; // Return the index of the pivot element
        }

        private static void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i]; // Swap the elements at the given indices
            arr[i] = arr[j];
            arr[j] = temp;
        }

    }
}
