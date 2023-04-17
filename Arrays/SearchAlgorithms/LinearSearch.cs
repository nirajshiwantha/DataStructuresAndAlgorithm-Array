using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays.SearchAlgorithms
{
    public class LinearSearch
    {
        public int LinearSearchAlgo(int[] arr, int key)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == key)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
