﻿using Arrays.BasicOperations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays.SortingAlgorithms
{
    public class HeapSort
    {
        public void HeapSortAlgo(int[] arr)
        {
            int n = arr.Length;

            // Build heap (rearrange array)
            for (int i = n / 2 - 1; i >= 0; i--)
            {
                Heapify(arr, n, i);
            }

            // One by one extract an element from heap
            for (int i = n - 1; i >= 0; i--)
            {
                // Move current root to end
                int temp = arr[0];
                arr[0] = arr[i];
                arr[i] = temp;

                // Call max heapify on the reduced heap
                Heapify(arr, i, 0);
            }

            BasicArrayOperations basicOps = new BasicArrayOperations();
            basicOps.PrintArray(arr);
        }

        private static void Heapify(int[] arr, int n, int i)
        {
            int largest = i; // Initialize largest as root
            int l = 2 * i + 1; // left = 2*i + 1
            int r = 2 * i + 2; // right = 2*i + 2

            // If left child is larger than root
            if (l < n && arr[l] > arr[largest])
            {
                largest = l;
            }

            // If right child is larger than largest so far
            if (r < n && arr[r] > arr[largest])
            {
                largest = r;
            }

            // If largest is not root
            if (largest != i)
            {
                int swap = arr[i];
                arr[i] = arr[largest];
                arr[largest] = swap;

                // Recursively heapify the affected sub-tree
                Heapify(arr, n, largest);
            }
        }
    }
}
