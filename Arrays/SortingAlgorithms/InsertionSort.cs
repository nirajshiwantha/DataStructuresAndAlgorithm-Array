using Arrays.BasicOperations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays.SortingAlgorithms
{
    public class InsertionSort
    {
        public void InsertionSortAlgo(int[] arr)
        {
            
            int n = arr.Length;
            for (int i = 1; i < n; i++)
            {
                int key = arr[i];
                int j = i - 1;

                // Shift elements greater than the key to the right
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }

                // Insert the key in its correct position
                arr[j + 1] = key;
            }

            BasicArrayOperations basicOps = new BasicArrayOperations();
            basicOps.PrintArray(arr);
        }
    }
}
