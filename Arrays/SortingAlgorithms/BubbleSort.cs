using Arrays.BasicOperations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays.SortingAlgorithms
{
    public class BubbleSort
    {
        public void BubbleSortAlgo(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    // Swap adjacent elements if they are in the wrong order
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }

            BasicArrayOperations basicOps = new BasicArrayOperations();
            basicOps.PrintArray(arr);
        }
    }
}
