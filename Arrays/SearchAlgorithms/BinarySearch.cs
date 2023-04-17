﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays.SearchAlgorithms
{
    public class BinarySearch
    {
        public int BinarySearchAlgo(int[] arr, int key)
        {
            int left = 0;
            int right = arr.Length - 1;
            while (left <= right)
            {
                int mid = (left + right) / 2;
                if (arr[mid] == key)
                {
                    return mid;
                }
                else if (arr[mid] < key)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
            return -1;
        }
    }
}
