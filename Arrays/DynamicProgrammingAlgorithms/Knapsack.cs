using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays.DynamicProgrammingAlgorithms
{
    internal class Knapsack
    {
        // Function to solve the Knapsack problem
        public int KnapsackAlgo(int W, int[] wt, int[] val, int n)
        {
            // Create a 2D array to store the maximum value that can be obtained with the first i items and a weight limit of j
            int[,] K = new int[n + 1, W + 1];

            // Loop through each item and each possible weight limit
            for (int i = 0; i <= n; i++)
            {
                for (int w = 0; w <= W; w++)
                {
                    // Base case: no items or weight limit is 0, so the maximum value is 0
                    if (i == 0 || w == 0)
                        K[i, w] = 0;

                    // If the weight of the i-th item is less than or equal to the current weight limit, we have two choices:
                    // 1) Include the item, which means we add its value to the maximum value that can be obtained with the remaining items and weight limit
                    // 2) Exclude the item, which means we use the maximum value that can be obtained with the remaining items and weight limit
                    else if (wt[i - 1] <= w)
                        K[i, w] = Math.Max(val[i - 1] + K[i - 1, w - wt[i - 1]], K[i - 1, w]);

                    // If the weight of the i-th item is greater than the current weight limit, we can't include the item
                    // and we use the maximum value that can be obtained with the remaining items and weight limit
                    else
                        K[i, w] = K[i - 1, w];
                }
            }

            // The final element in the 2D array is the maximum value that can be obtained with all the items and weight limit W
            return K[n, W];
        }

    }
}
