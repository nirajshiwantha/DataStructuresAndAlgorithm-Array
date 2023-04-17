using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays.SearchAlgorithms
{
    public class ExponentialSearch
    {
        // Function to perform exponential search
        public  int ExponentialSearchAlgo(int[] arr, int key)
        {
            int n = arr.Length;
            // If key is found at first location itself
            if (arr[0] == key)
                return 0;

            // Find range for binary search by repeated doubling
            int i = 1;
            while (i < n && arr[i] <= key)
                i = i * 2;

            // Call binary search for the found range
            return BinarySearchFunc(arr, i / 2, Math.Min(i, n - 1), key);
        }

        // Function to perform binary search
        public static int BinarySearchFunc(int[] arr, int low, int high, int key)
        {
            if (high >= low)
            {
                int mid = low + (high - low) / 2;

                // If the element is present at the middle itself
                if (arr[mid] == key)
                    return mid;

                // If element is smaller than mid, then it can only
                // be present in left subarray
                if (arr[mid] > key)
                    return BinarySearchFunc(arr, low, mid - 1, key);

                // Else the element can only be present in right subarray
                return BinarySearchFunc(arr, mid + 1, high, key);
            }

            // We reach here when element is not present in array
            return -1;
        }
    }
}
