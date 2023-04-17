using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays.SearchAlgorithms
{
    public class JumpSearch
    {
        public int JumpSearchAlgo(int[] arr, int x)
        {
            int n = arr.Length;

            // Finding block size to be jumped
            int step = (int)Math.Floor(Math.Sqrt(n));

            // Finding the block where the element is present
            int prev = 0;
            while (arr[Math.Min(step, n) - 1] < x)
            {
                prev = step;
                step += (int)Math.Floor(Math.Sqrt(n));
                if (prev >= n)
                    return -1;
            }

            // Doing a linear search for x in block
            while (arr[prev] < x)
            {
                prev++;

                // If we reached the next block or end of the array, element is not present.
                if (prev == Math.Min(step, n))
                    return -1;
            }

            // If element is found
            if (arr[prev] == x)
                return prev;

            return -1;
        }
    }
}
