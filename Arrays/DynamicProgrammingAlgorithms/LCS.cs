using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays.DynamicProgrammingAlgorithms
{
    public class LCS
    {
        // function to calculate the length of the longest common subsequence
        public int LcsAlgo(string s1, string s2)
        {
            // create a 2D array to store the lengths of common subsequences
            int[,] lengths = new int[s1.Length + 1, s2.Length + 1];

            // iterate over the length of the two strings
            for (int i = 0; i <= s1.Length; i++)
            {
                for (int j = 0; j <= s2.Length; j++)
                {
                    // if either of the strings has length 0, then no common subsequence can exist
                    if (i == 0 || j == 0)
                        lengths[i, j] = 0;

                    // if the characters at the current positions of both strings match,
                    // then increment the length of the longest common subsequence by 1
                    else if (s1[i - 1] == s2[j - 1])
                        lengths[i, j] = lengths[i - 1, j - 1] + 1;

                    // if the characters at the current positions of both strings do not match,
                    // then choose the maximum length of the two subproblems:
                    // (1) ignoring the current character in s1 and checking the remaining characters in s2
                    // (2) ignoring the current character in s2 and checking the remaining characters in s1
                    else
                        lengths[i, j] = Math.Max(lengths[i - 1, j], lengths[i, j - 1]);
                }
            }

            // the length of the longest common subsequence will be stored in the last cell of the 2D array
            return lengths[s1.Length, s2.Length];
        }
    }
}
