using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays.DataCompressionAlgorithms
{
    public class LZWCompression
    {
        // A method to compress the input text using LZW algorithm
        public List<int> Compress(string inputText)
        {
            // Create a dictionary to store the initial ASCII characters as keys and their corresponding indices as values
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            for (int i = 0; i < 128; i++)
            {
                dictionary.Add(((char)i).ToString(), i);
            }

            string currentSubstring = string.Empty; // A string to store the current substring
            List<int> output = new List<int>(); // A list to store the compressed output

            foreach (char c in inputText)
            {
                string newSubstring = currentSubstring + c; // Add the new character to the current substring

                if (dictionary.ContainsKey(newSubstring))
                {
                    // If the new substring is already in the dictionary, update the current substring and continue processing the next character
                    currentSubstring = newSubstring;
                }
                else
                {
                    // If the new substring is not in the dictionary, add it to the dictionary with a new index and output the index of the current substring
                    output.Add(dictionary[currentSubstring]);
                    dictionary.Add(newSubstring, dictionary.Count);
                    currentSubstring = c.ToString();
                }
            }

            // Output the index of the final substring
            if (!string.IsNullOrEmpty(currentSubstring))
            {
                output.Add(dictionary[currentSubstring]);
            }

            return output;
        }

        // A method to decompress the compressed output using LZW algorithm
        public string Decompress(List<int> compressedOutput)
        {
            // Create a dictionary to store the initial ASCII characters as keys and their corresponding indices as values
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            for (int i = 0; i < 256; i++)
            {
                dictionary.Add(i, ((char)i).ToString());
            }

            string previousSubstring = dictionary[compressedOutput[0]]; // The previous substring is initialized with the first character
            string output = previousSubstring;

            for (int i = 1; i < compressedOutput.Count; i++)
            {
                string currentSubstring = string.Empty;

                if (dictionary.ContainsKey(compressedOutput[i]))
                {
                    currentSubstring = dictionary[compressedOutput[i]];
                }
                else if (compressedOutput[i] == dictionary.Count)
                {
                    currentSubstring = previousSubstring + previousSubstring[0];
                }

                output += currentSubstring;

                // Add the new entry to the dictionary
                dictionary.Add(dictionary.Count, previousSubstring + currentSubstring[0]);

                // Update the previous substring
                previousSubstring = currentSubstring;
            }

            return output;
        }
    }
}
