using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays.SearchAlgorithms
{
    /// <summary>
    /// Class to implement Interpolation search algorithm
    /// </summary>
    public class InterpolationSearch
    {
        /// <summary>
        /// Method to perform Interpolation search on an array
        /// </summary>
        /// <param name="arr">Array to search</param>
        /// <param name="key">Element to search for</param>
        /// <returns>Index of the element if found, else -1</returns>
        public int InterpolationSearchAlgo(int[] arr, int key)
        {
            int left = 0;
            int right = arr.Length - 1;
            
            // Keep searching while key is within the bounds of the array
            while (left <= right && key >= arr[left] && key <= arr[right])
            {
                // Interpolate the position of the key
                int pos = left + ((key - arr[left]) * (right - left)) / (arr[right] - arr[left]);
                
                if (arr[pos] == key)
                {
                    // Key found
                    return pos;
                }
                else if (arr[pos] < key)
                {
                    // Key is in the right subarray
                    left = pos + 1;
                }
                else
                {
                    // Key is in the left subarray
                    right = pos - 1;
                }
            }
            
            // Key not found
            return -1;
        }
    }
}