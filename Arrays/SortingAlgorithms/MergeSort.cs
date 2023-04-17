using Arrays.BasicOperations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays.SortingAlgorithms
{
    public class MergeSort
    {
        public void MergeSortAlgo(int[] arr, int left, int right)
        {
            if (arr == null || arr.Length == 0) // Check if the array is empty or null
            {
                return;
            }

            int[] temp = new int[arr.Length]; // Create a temporary array to store the sorted elements
            MergeSortHelper(arr, temp, left, right); // Call the helper function to sort the array

            BasicArrayOperations basicOps = new BasicArrayOperations();
            basicOps.PrintArray(arr);
        }

        private static void MergeSortHelper(int[] arr, int[] temp, int left, int right)
        {
            if (left < right) // Check if there are at least two elements in the subarray
            {
                int mid = (left + right) / 2; // Calculate the middle index

                MergeSortHelper(arr, temp, left, mid); // Sort the left half of the subarray
                MergeSortHelper(arr, temp, mid + 1, right); // Sort the right half of the subarray

                Merge(arr, temp, left, mid, right); // Merge the two sorted halves
            }
        }

        private static void Merge(int[] arr, int[] temp, int left, int mid, int right)
        {
            int i = left; // Index for the left half of the subarray
            int j = mid + 1; // Index for the right half of the subarray
            int k = left; // Index for the temporary array

            while (i <= mid && j <= right) // Loop through both halves until one is fully traversed
            {
                if (arr[i] <= arr[j]) // Compare the values at the current indices
                {
                    temp[k++] = arr[i++]; // Place the smaller value in the temporary array
                }
                else
                {
                    temp[k++] = arr[j++];
                }
            }

            while (i <= mid) // Copy any remaining elements from the left half
            {
                temp[k++] = arr[i++];
            }

            while (j <= right) // Copy any remaining elements from the right half
            {
                temp[k++] = arr[j++];
            }

            for (int l = left; l <= right; l++) // Copy the sorted elements from the temporary array back into the original array
            {
                arr[l] = temp[l];
            }
        }

    }
}
