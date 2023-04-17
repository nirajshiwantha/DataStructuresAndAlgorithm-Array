using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays.DataCompressionAlgorithms
{
    public class RunLengthEncoding
    {
        // A method to compress the input text using RLE algorithm
        public string Compress(string inputText)
        {
            string output = string.Empty;

            // Loop through the input text, grouping consecutive identical characters together
            int count = 1;
            char currentChar = inputText[0];
            for (int i = 1; i < inputText.Length; i++)
            {
                if (inputText[i] == currentChar)
                {
                    count++;
                }
                else
                {
                    // Output the count and current character, and reset the count and current character to start a new group
                    output += count.ToString() + currentChar;
                    count = 1;
                    currentChar = inputText[i];
                }
            }

            // Output the final group
            output += count.ToString() + currentChar;

            return output;
        }

        // A method to decompress the compressed output using RLE algorithm
        public string Decompress(string compressedOutput)
        {
            string output = string.Empty;

            // Loop through the compressed output, extracting the count and current character for each group and repeating the character the specified number of times
            for (int i = 0; i < compressedOutput.Length; i += 2)
            {
                int count = int.Parse(compressedOutput[i].ToString());
                char currentChar = compressedOutput[i + 1];

                for (int j = 0; j < count; j++)
                {
                    output += currentChar;
                }
            }

            return output;
        }
    }
}
